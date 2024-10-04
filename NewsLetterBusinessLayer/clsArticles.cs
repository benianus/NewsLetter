using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsLetterDataLayer;

namespace NewsLetterBusinessLayer
{
    public class clsArticles
    {
        public enum enMode
        {
            AddNew = 1,
            Update = 2
        }
        public enMode Mode { get; set; }
        public clsArticles(int articleID, string articleTitle, string articleContent, DateTime publishingDate, int publisherID)
        {
            this.ArticleID = articleID;
            this.ArticleTitle = articleTitle;
            this.ArticleContent = articleContent;
            this.PublishingDate = publishingDate;
            this.PublisherID = publisherID;

            this.Mode = enMode.Update;
        }
        public clsArticles()
        {
            this.ArticleID = 0;
            this.ArticleTitle = string.Empty;
            this.ArticleContent = string.Empty; 
            this.PublishingDate = DateTime.MinValue;
            this.PublisherID = 0;

            this.Mode = enMode.AddNew;
        }
        public int ArticleID { get; set; }
        public string ArticleTitle {  get; set; }
        public string ArticleContent { get; set; }
        public DateTime PublishingDate { get; set; }
        public int PublisherID { get; set; }   
        
        public static DataTable GetAllArticles()
        {
            return clsArticlesData.GetAllArticles();
        }
        public static clsArticles GetArticleByID(int ArticleID)
        {
            string ArticleTitle = string.Empty;
            string ArticleContent = string.Empty;
            DateTime PublishingDate = DateTime.MinValue;
            int PublisherID = 0;

            if (clsArticlesData.GetArticleByID(ArticleID, ref ArticleTitle, ref ArticleContent, ref PublishingDate, ref PublisherID))
            {
                return new clsArticles(ArticleID, ArticleTitle, ArticleContent, PublishingDate, PublisherID);
            }
            else
            {
                return null;
            }
        }
        public bool AddNewArticle()
        {
            this.ArticleID = clsArticlesData.AddNewArticle(this.ArticleTitle, this.ArticleContent, this.PublishingDate);

            return this.ArticleID > 0;
        }
        public bool UpdateArticle()
        {
            return clsArticlesData.UpdateArticle(this.ArticleID, this.ArticleTitle, this.ArticleContent, this.PublishingDate, this.PublisherID);
        }
        public static bool DeleteArticle(int ArticleID)
        {
            return clsArticlesData.DeleteArticle(ArticleID);   
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    Mode = enMode.Update;
                    return AddNewArticle();
                case enMode.Update:
                    return UpdateArticle();

            }
            return false;
        }
    }
}
