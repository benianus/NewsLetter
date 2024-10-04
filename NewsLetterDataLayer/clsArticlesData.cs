using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsLetterDataLayer
{
    public class clsArticlesData
    {
        public static DataTable GetAllArticles()
        {
            DataTable ArticlesTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "SELECT * FROM Articles;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    ArticlesTable.Load(reader);
                }

                reader.Close();
            }
            finally
            {
                connection.Close();
            }

            return ArticlesTable;
        }
        public static bool GetArticleByID(int ArticleID, ref string ArticleTitle, ref string ArticleContent, ref DateTime PublishingDate, ref int PublisherID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "SELECT * FROM Articles WHERE ArticleID = @ArticleID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ArticleID", ArticleID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    ArticleTitle = (string)reader["ArticleTitle"];
                    ArticleContent = (string)reader["ArticleContent"];
                    PublishingDate = (DateTime)reader["PublishingDate"];
                    if (reader["PublisherID"] != System.DBNull.Value)
                    {
                        PublisherID = (int)reader["PublisherID"];
                    }
                    else
                    {
                        PublisherID = 0;
                    }
                }

                reader.Close();
            }
            finally
            {
                connection.Close();
            }

            return isFound; 
        }
        public static int AddNewArticle(string ArticleTitle, string ArticleContent, DateTime PublishingDate)
        {
            int ArticleID = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "INSERT INTO Articles (ArticleTitle, ArticleContent, PublishingDate) VALUES (@ArticleTitle, @ArticleContent, @PublishingDate);" +
                " SELECT SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ArticleTitle", ArticleTitle);
            command.Parameters.AddWithValue("@ArticleContent", ArticleContent);
            command.Parameters.AddWithValue("@PublishingDate", PublishingDate);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ArticleID = insertedID;
                }
            }
            finally
            {
                connection.Close();
            }

            return ArticleID;
        }
        public static bool UpdateArticle(int ArticleID, string ArticleTitle, string ArticleContent, DateTime PublishingDate, int PublisherID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "Update Articles SET " +
                " ArticleTitle = @ArticleTitle," +
                " ArticleContent = @ArticleContent" +
                " WHERE ArticleID = @ArticleID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ArticleTitle", ArticleTitle);
            command.Parameters.AddWithValue("@ArticleID", ArticleID);
            command.Parameters.AddWithValue("@ArticleContent", ArticleContent);

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
        public static bool DeleteArticle(int ArticleID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "DELETE FROM Articles WHERE ArticleID = @ArticleID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ArticleID", ArticleID);

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
