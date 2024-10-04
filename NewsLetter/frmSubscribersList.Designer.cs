namespace NewsLetter
{
    partial class frmSubscribersList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvSubscribers = new System.Windows.Forms.DataGridView();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmsSubscribers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSubscriberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unsubscribeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscribers)).BeginInit();
            this.cmsSubscribers.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSubscribers
            // 
            this.dgvSubscribers.AllowUserToAddRows = false;
            this.dgvSubscribers.AllowUserToDeleteRows = false;
            this.dgvSubscribers.AllowUserToOrderColumns = true;
            this.dgvSubscribers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSubscribers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubscribers.ContextMenuStrip = this.cmsSubscribers;
            this.dgvSubscribers.Location = new System.Drawing.Point(20, 121);
            this.dgvSubscribers.Margin = new System.Windows.Forms.Padding(5);
            this.dgvSubscribers.Name = "dgvSubscribers";
            this.dgvSubscribers.ReadOnly = true;
            this.dgvSubscribers.Size = new System.Drawing.Size(582, 533);
            this.dgvSubscribers.TabIndex = 1;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Location = new System.Drawing.Point(102, 672);
            this.lblRecordCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(28, 21);
            this.lblRecordCount.TabIndex = 4;
            this.lblRecordCount.Text = "??";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 672);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Records:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 44);
            this.label2.TabIndex = 11;
            this.label2.Text = "Subscribers";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(527, 672);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmsSubscribers
            // 
            this.cmsSubscribers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSubscriberToolStripMenuItem,
            this.unsubscribeToolStripMenuItem});
            this.cmsSubscribers.Name = "cmsSubscribers";
            this.cmsSubscribers.Size = new System.Drawing.Size(166, 48);
            // 
            // deleteSubscriberToolStripMenuItem
            // 
            this.deleteSubscriberToolStripMenuItem.Name = "deleteSubscriberToolStripMenuItem";
            this.deleteSubscriberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteSubscriberToolStripMenuItem.Text = "Delete Subscriber";
            this.deleteSubscriberToolStripMenuItem.Click += new System.EventHandler(this.deleteSubscriberToolStripMenuItem_Click);
            // 
            // unsubscribeToolStripMenuItem
            // 
            this.unsubscribeToolStripMenuItem.Name = "unsubscribeToolStripMenuItem";
            this.unsubscribeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unsubscribeToolStripMenuItem.Text = "Unsubscribe";
            this.unsubscribeToolStripMenuItem.Click += new System.EventHandler(this.unsubscribeToolStripMenuItem_Click);
            // 
            // frmSubscribersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(628, 727);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSubscribers);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSubscribersList";
            this.Text = "frmSubscribersList";
            this.Load += new System.EventHandler(this.frmSubscribersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscribers)).EndInit();
            this.cmsSubscribers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubscribers;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip cmsSubscribers;
        private System.Windows.Forms.ToolStripMenuItem deleteSubscriberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unsubscribeToolStripMenuItem;
    }
}