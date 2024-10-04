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
    public partial class frmArticlesPublished : Form
    {
        public delegate void eventEditArticel(int ArticleID);
        public event eventEditArticel EditArticle;

        public frmArticlesPublished()
        {
            InitializeComponent();
        }

        private void frmArticlesPublished_Load(object sender, EventArgs e)
        {
            DataTable dtArticles = clsArticles.GetAllArticles();
            dgvArticles.DataSource = dtArticles;
            lblRecordCount.Text = dgvArticles.RowCount.ToString();  
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmArticleHome frmArticleHome = new frmArticleHome();
            frmArticleHome.ShowDialog();
            this.Close();
        }

        private void deleteArticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete The Article", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            if (clsArticles.DeleteArticle(Convert.ToInt32(dgvArticles.CurrentRow.Cells["ArticleID"].Value)))
            {
                MessageBox.Show("Article Deleted successfully!");
                frmArticlesPublished_Load(null, null);
            }
            else
            {
                MessageBox.Show("Failed to delete this article!");
            }
        }

        private void EdittoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            EditArticle(Convert.ToInt32(dgvArticles.CurrentRow.Cells["ArticleID"].Value));
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
