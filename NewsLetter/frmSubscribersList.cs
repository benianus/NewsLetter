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
    public partial class frmSubscribersList : Form
    {
        public delegate void eventRershSubscriberCount();
        public event eventRershSubscriberCount _RefreshSubscriberCount;
        public frmSubscribersList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _RefreshSubscriberCount();
            this.Close();
        }

        private void frmSubscribersList_Load(object sender, EventArgs e)
        {
            dgvSubscribers.DataSource = clsSubscribers.GetAllSubscribers();
            lblRecordCount.Text = dgvSubscribers.Rows.Count.ToString();
        }

        private void deleteSubscriberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete This subscriber", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            if (clsSubscribers.DeleteSubscriber(Convert.ToInt32(dgvSubscribers.CurrentRow.Cells["SubscriberID"].Value)))
            {
                MessageBox.Show("Subscriber Deleted successfully!");
                frmSubscribersList_Load(null, null);
            }
            else
            {
                MessageBox.Show("Failed to delete this subscriber!");
            }
        }

        private void unsubscribeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsSubscribers.UpdateSubscriber(Convert.ToInt32(dgvSubscribers.CurrentRow.Cells["SubscriberID"].Value));
            frmSubscribersList_Load(null, null);
        }
    }
}
