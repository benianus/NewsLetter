using NewsLetterDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsLetterBusinessLayer
{
    public class clsSubscribers
    {
        public enum enMode
        {
            AddNew = 1,
            Update = 2
        }
        public enMode Mode { get; set; }
        public clsSubscribers(int subscriberID, string fullName, string email, DateTime subscribtionDate, bool isSubscribed)
        {
            this.SubscriberID = subscriberID;
            this.FullName = fullName;
            this.Email = email;
            this.SubscribtionDate = subscribtionDate;
            this.IsSubscribed = isSubscribed;

            this.Mode = enMode.Update;
        }
        public clsSubscribers()
        {
            this.SubscriberID = 0;
            this.FullName = string.Empty;
            this.Email = string.Empty;
            this.SubscribtionDate = DateTime.MinValue;
            this.IsSubscribed = false;

            this.Mode = enMode.AddNew;
        }
        public int SubscriberID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime SubscribtionDate { get; set; }
        public bool IsSubscribed { get; set; }

        public static DataTable GetAllSubscribers()
        {
            return clsSubscribersData.GetAllSubscribers();
        }
        public static clsSubscribers GetSubscriberByID(int subscriberID)
        {
            string FullName = string.Empty;
            string Email = string.Empty;
            DateTime SubscribtionDate = DateTime.Now;
            bool IsSubscribed = false;
            if (clsSubscribersData.GetSubscriberByID(subscriberID, ref FullName, ref Email, ref SubscribtionDate, ref IsSubscribed))
            {
                return new clsSubscribers(subscriberID, FullName, Email, SubscribtionDate, IsSubscribed);
            }
            else
            {
                return null;
            }
        }
        public bool AddNewSubscriber()
        {
            this.SubscriberID = clsSubscribersData.AddNewSubscriber(this.FullName, this.Email, this.SubscribtionDate, this.IsSubscribed);

            return this.SubscriberID > 0;
        }
        public bool UpdateSubscriber()
        {
            return clsSubscribersData.UpdateSubscriber(this.SubscriberID, this.FullName, this.Email, this.SubscribtionDate, this.IsSubscribed);
        }
        public static bool UpdateSubscriber(int SubscriberID)
        {
            return clsSubscribersData.UpdateSubscriber(SubscriberID);
        }
        public static bool DeleteSubscriber(int SubscriberID)
        {
            return clsSubscribersData.DeleteSubscriber(SubscriberID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    Mode = enMode.Update;
                    return AddNewSubscriber();
                case enMode.Update:
                    return UpdateSubscriber();

            }
            return false;
        }
    }
}
