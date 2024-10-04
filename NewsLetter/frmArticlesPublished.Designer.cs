namespace NewsLetter
{
    partial class frmArticlesPublished
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
            this.dgvArticles = new System.Windows.Forms.DataGridView();
            this.cmsArticles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EdittoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).BeginInit();
            this.cmsArticles.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticles
            // 
            this.dgvArticles.AllowUserToAddRows = false;
            this.dgvArticles.AllowUserToDeleteRows = false;
            this.dgvArticles.AllowUserToOrderColumns = true;
            this.dgvArticles.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticles.ContextMenuStrip = this.cmsArticles;
            this.dgvArticles.Location = new System.Drawing.Point(20, 137);
            this.dgvArticles.Margin = new System.Windows.Forms.Padding(5);
            this.dgvArticles.Name = "dgvArticles";
            this.dgvArticles.ReadOnly = true;
            this.dgvArticles.Size = new System.Drawing.Size(582, 533);
            this.dgvArticles.TabIndex = 0;
            // 
            // cmsArticles
            // 
            this.cmsArticles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.EdittoolStripMenuItem1,
            this.deleteArticleToolStripMenuItem});
            this.cmsArticles.Name = "cmsArticles";
            this.cmsArticles.Size = new System.Drawing.Size(181, 92);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddToolStripMenuItem.Text = "Add New Article";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // EdittoolStripMenuItem1
            // 
            this.EdittoolStripMenuItem1.Name = "EdittoolStripMenuItem1";
            this.EdittoolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.EdittoolStripMenuItem1.Text = "Edit Article";
            this.EdittoolStripMenuItem1.Click += new System.EventHandler(this.EdittoolStripMenuItem1_Click);
            // 
            // deleteArticleToolStripMenuItem
            // 
            this.deleteArticleToolStripMenuItem.Name = "deleteArticleToolStripMenuItem";
            this.deleteArticleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteArticleToolStripMenuItem.Text = "Delete Article";
            this.deleteArticleToolStripMenuItem.Click += new System.EventHandler(this.deleteArticleToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 691);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Records:";
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Location = new System.Drawing.Point(106, 691);
            this.lblRecordCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(28, 21);
            this.lblRecordCount.TabIndex = 2;
            this.lblRecordCount.Text = "??";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 44);
            this.label3.TabIndex = 12;
            this.label3.Text = "Articles";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(526, 688);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdd.Location = new System.Drawing.Point(526, 95);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 34);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // frmArticlesPublished
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(624, 746);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvArticles);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmArticlesPublished";
            this.Text = "frmArticlesPublished";
            this.Load += new System.EventHandler(this.frmArticlesPublished_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).EndInit();
            this.cmsArticles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip cmsArticles;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EdittoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteArticleToolStripMenuItem;
        private System.Windows.Forms.Button btnAdd;
    }
}