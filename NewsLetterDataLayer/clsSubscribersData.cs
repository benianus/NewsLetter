using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsLetterDataLayer
{
    public class clsSubscribersData
    {
        public static DataTable GetAllSubscribers()
        {
            DataTable dtSubscribers = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "SELECT * FROM Subscribers;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtSubscribers.Load(reader);
                }

                reader.Close(); 
            }
            finally
            {
                connection.Close();
            }

            return dtSubscribers;
        }
        public static bool GetSubscriberByID(int SubscriberID, ref string FullName, ref string Email, ref DateTime SubscribtionDate, ref bool IsSubscribed)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "SELECT * FROM Suscribers WHERE SubscriberID = @SubscriberID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SubscriberID", SubscriberID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    isFound = true;

                    FullName = (string)reader["FullName"];
                    Email = (string)reader["Email"];
                    SubscribtionDate = (DateTime)reader["SubscribtionDate"];
                    IsSubscribed = (bool)reader["IsSubscribed"];
                }
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static int AddNewSubscriber(string FullName, string Email, DateTime SubscribtionDate, bool IsSubscribed)
        {
            int SubscriberID = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "INSERT INTO Subscribers (FullName, Email, SubscribtionDate, IsSubscribed) VALUES (@FullName, @Email, @SubscribtionDate, @IsSubscribed);" +
                " SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FullName", FullName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@SubscribtionDate", SubscribtionDate);
            command.Parameters.AddWithValue("@IsSubscribed", IsSubscribed);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    SubscriberID = insertedID;
                }
            }
            finally
            {
                connection.Close();
            }

            return SubscriberID;
        }
        public static bool UpdateSubscriber(int SubscriberID, string FullName, string Email, DateTime SubscribtionDate, bool IsSubscribed)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "UPDATE Subscribers SET IsSubscribed = false WHERE SubscriberID = @SubscriberID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SubscriberID", SubscriberID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }
        public static bool UpdateSubscriber(int SubscriberID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "UPDATE Subscribers SET IsSubscribed = 0 WHERE SubscriberID = @SubscriberID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SubscriberID", SubscriberID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }
        public static bool DeleteSubscriber(int SubscriberID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "DELETE FROM Subscribers WHERE SubscriberID = @SubscriberID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SubscriberID", SubscriberID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }
    }
}
