using NewsLetterBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsLetter
{
    public partial class frmArticleHome : Form
    {
        public enum enMode
        {
            AddNew = 1,
            Update = 2
        }
        public frmArticleHome()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmArticleHome(int ArticleID)
        {
            InitializeComponent();
            _ArticleID = ArticleID;
            _Mode = enMode.Update;
        }

        public enMode _Mode = enMode.AddNew;
        private int _ArticleID;
        //private int _SubscriberID;

        private clsArticles _Article;
        private clsSubscribers _Subscriber;

        //Functions
        private void _PublishArticle()
        {
            if(MessageBox.Show("Are you sure to publish this Article", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            _Article.ArticleTitle = txtTitle.Text;
            _Article.ArticleContent = txtContent.Text;
            _Article.PublishingDate = DateTime.Now;
            _Article.PublisherID = 1;

            if (_Article.Save())
            {
                MessageBox.Show("Article Saved Successfully");
                raiseOnPublish(_Article.ArticleTitle, lblSubscribersCount.Text);
            }
        }
        public void raiseOnPublish(string ArticleTitle, string subsribersCount)
        {
            MessageBox.Show($"Article with title \"{_Article.ArticleTitle}\" Sent to {subsribersCount} all subscribers successfully");
        }

        private void _SubscribersCount()
        {
            lblSubscribersCount.Text = clsSubscribers.GetAllSubscribers().Rows.Count.ToString();
        }

        //buttons
        private void frmArticleHome_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                this.Text = "Add Article";
                _Article = new clsArticles();
                _SubscribersCount();

                return;
            }

            //_ArticleEditMode();
        }

        private void _ArticleEditMode(int ArticleID = 0)
        {
            _ArticleID = ArticleID;
            _SubscribersCount();
            this.Text = "Edit Article";
            _Article = clsArticles.GetArticleByID(_ArticleID);

            if (_Article == null) 
            {
                MessageBox.Show("There is No Article with this Article ID");
                return;
            }

            txtTitle.Text = _Article.ArticleContent;
            txtContent.Text = _Article.ArticleContent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubscribers_Click(object sender, EventArgs e)
        {
            frmSubscribersList subscribersList = new frmSubscribersList();
            subscribersList._RefreshSubscriberCount += _SubscribersCount;
            subscribersList.ShowDialog();
        }
        private void btnArticles_Click(object sender, EventArgs e)
        {
            frmArticlesPublished articlesPublished = new frmArticlesPublished();
            articlesPublished.EditArticle += _ArticleEditMode;
            articlesPublished.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            _PublishArticle();
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to subscribe to this newsletter", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            _Subscriber = new clsSubscribers();

            _Subscriber.FullName = txtName.Text;
            _Subscriber.Email = txtEmail.Text;
            _Subscriber.SubscribtionDate = DateTime.Now;
            _Subscriber.IsSubscribed = true;
            
            if (_Subscriber.Save())
            {
                MessageBox.Show("Subsctiption Saved Successfully");
                _SubscribersCount();
            }
        }
    }
}
