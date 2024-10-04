namespace NewsLetter
{
    partial class frmArticleHome
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubscribers = new System.Windows.Forms.Button();
            this.btnArticles = new System.Windows.Forms.Button();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnEmail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnPublish = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSubscribersCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Content:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(676, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "Articles Newsletter";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(461, 170);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(557, 31);
            this.txtTitle.TabIndex = 7;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(461, 223);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(778, 351);
            this.txtContent.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(78, 459);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(238, 60);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSubscribers
            // 
            this.btnSubscribers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubscribers.Location = new System.Drawing.Point(78, 345);
            this.btnSubscribers.Margin = new System.Windows.Forms.Padding(5);
            this.btnSubscribers.Name = "btnSubscribers";
            this.btnSubscribers.Size = new System.Drawing.Size(238, 60);
            this.btnSubscribers.TabIndex = 10;
            this.btnSubscribers.Text = "Subscribers";
            this.btnSubscribers.UseVisualStyleBackColor = true;
            this.btnSubscribers.Click += new System.EventHandler(this.btnSubscribers_Click);
            // 
            // btnArticles
            // 
            this.btnArticles.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnArticles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticles.Location = new System.Drawing.Point(78, 231);
            this.btnArticles.Margin = new System.Windows.Forms.Padding(5);
            this.btnArticles.Name = "btnArticles";
            this.btnArticles.Size = new System.Drawing.Size(238, 60);
            this.btnArticles.TabIndex = 8;
            this.btnArticles.Text = "Articles";
            this.btnArticles.UseVisualStyleBackColor = true;
            this.btnArticles.Click += new System.EventHandler(this.btnArticles_Click);
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSubscribe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubscribe.Location = new System.Drawing.Point(1070, 616);
            this.btnSubscribe.Margin = new System.Windows.Forms.Padding(5);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(169, 31);
            this.btnSubscribe.TabIndex = 14;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(831, 616);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(231, 31);
            this.txtEmail.TabIndex = 15;
            // 
            // btnEmail
            // 
            this.btnEmail.AutoSize = true;
            this.btnEmail.Location = new System.Drawing.Point(770, 621);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(55, 21);
            this.btnEmail.TabIndex = 16;
            this.btnEmail.Text = "Email:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(525, 618);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(231, 31);
            this.txtName.TabIndex = 17;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(457, 621);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 21);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name:";
            // 
            // btnPublish
            // 
            this.btnPublish.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPublish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublish.Location = new System.Drawing.Point(1030, 170);
            this.btnPublish.Margin = new System.Windows.Forms.Padding(5);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(209, 31);
            this.btnPublish.TabIndex = 19;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 677);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Subscribers:";
            // 
            // lblSubscribersCount
            // 
            this.lblSubscribersCount.AutoSize = true;
            this.lblSubscribersCount.Location = new System.Drawing.Point(570, 677);
            this.lblSubscribersCount.Name = "lblSubscribersCount";
            this.lblSubscribersCount.Size = new System.Drawing.Size(37, 21);
            this.lblSubscribersCount.TabIndex = 21;
            this.lblSubscribersCount.Text = "???";
            // 
            // frmArticleHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1333, 727);
            this.Controls.Add(this.lblSubscribersCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubscribers);
            this.Controls.Add(this.btnArticles);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmArticleHome";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmArticleHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubscribers;
        private System.Windows.Forms.Button btnArticles;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label btnEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSubscribersCount;
    }
}

