namespace FacebookApplication
{
    partial class LikeAnalyzerForm
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
            this.listBox_DescendingLikeFriends = new System.Windows.Forms.ListBox();
            this.PictureBox_SelectedFriend = new System.Windows.Forms.PictureBox();
            this.listBox_RecentPost = new System.Windows.Forms.ListBox();
            this.button_LikeBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_AmountPostsToParse = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_AmountOfLikes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_SelectedFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_DescendingLikeFriends
            // 
            this.listBox_DescendingLikeFriends.FormattingEnabled = true;
            this.listBox_DescendingLikeFriends.ItemHeight = 16;
            this.listBox_DescendingLikeFriends.Location = new System.Drawing.Point(16, 246);
            this.listBox_DescendingLikeFriends.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_DescendingLikeFriends.Name = "listBox_DescendingLikeFriends";
            this.listBox_DescendingLikeFriends.Size = new System.Drawing.Size(159, 260);
            this.listBox_DescendingLikeFriends.TabIndex = 0;
            this.listBox_DescendingLikeFriends.SelectedIndexChanged += new System.EventHandler(this.listBox_DescendingLikeFriends_SelectedIndexChanged);
            // 
            // PictureBox_SelectedFriend
            // 
            this.PictureBox_SelectedFriend.Location = new System.Drawing.Point(233, 246);
            this.PictureBox_SelectedFriend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PictureBox_SelectedFriend.Name = "PictureBox_SelectedFriend";
            this.PictureBox_SelectedFriend.Size = new System.Drawing.Size(133, 106);
            this.PictureBox_SelectedFriend.TabIndex = 1;
            this.PictureBox_SelectedFriend.TabStop = false;
            // 
            // listBox_RecentPost
            // 
            this.listBox_RecentPost.FormattingEnabled = true;
            this.listBox_RecentPost.ItemHeight = 16;
            this.listBox_RecentPost.Location = new System.Drawing.Point(233, 390);
            this.listBox_RecentPost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_RecentPost.Name = "listBox_RecentPost";
            this.listBox_RecentPost.Size = new System.Drawing.Size(265, 116);
            this.listBox_RecentPost.TabIndex = 2;
            // 
            // button_LikeBack
            // 
            this.button_LikeBack.Location = new System.Drawing.Point(400, 324);
            this.button_LikeBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_LikeBack.Name = "button_LikeBack";
            this.button_LikeBack.Size = new System.Drawing.Size(100, 28);
            this.button_LikeBack.TabIndex = 3;
            this.button_LikeBack.Text = "Like Back";
            this.button_LikeBack.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "RunAnalysis";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_AmountPostsToParse
            // 
            this.textBox_AmountPostsToParse.Location = new System.Drawing.Point(421, 118);
            this.textBox_AmountPostsToParse.Name = "textBox_AmountPostsToParse";
            this.textBox_AmountPostsToParse.Size = new System.Drawing.Size(100, 22);
            this.textBox_AmountPostsToParse.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(398, 263);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label_AmountOfLikes
            // 
            this.label_AmountOfLikes.AutoSize = true;
            this.label_AmountOfLikes.Location = new System.Drawing.Point(400, 240);
            this.label_AmountOfLikes.Name = "label_AmountOfLikes";
            this.label_AmountOfLikes.Size = new System.Drawing.Size(112, 17);
            this.label_AmountOfLikes.TabIndex = 7;
            this.label_AmountOfLikes.Text = "Amount Of Likes";
            // 
            // LikeAnalyzerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 615);
            this.Controls.Add(this.label_AmountOfLikes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox_AmountPostsToParse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_LikeBack);
            this.Controls.Add(this.listBox_RecentPost);
            this.Controls.Add(this.PictureBox_SelectedFriend);
            this.Controls.Add(this.listBox_DescendingLikeFriends);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LikeAnalyzerForm";
            this.Text = "Like Analyzer ";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_SelectedFriend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_DescendingLikeFriends;
        private System.Windows.Forms.PictureBox PictureBox_SelectedFriend;
        private System.Windows.Forms.ListBox listBox_RecentPost;
        private System.Windows.Forms.Button button_LikeBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_AmountPostsToParse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_AmountOfLikes;
    }
}