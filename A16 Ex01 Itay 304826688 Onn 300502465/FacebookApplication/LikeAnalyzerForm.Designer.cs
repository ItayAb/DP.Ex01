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
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_SelectedFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_DescendingLikeFriends
            // 
            this.listBox_DescendingLikeFriends.FormattingEnabled = true;
            this.listBox_DescendingLikeFriends.Location = new System.Drawing.Point(12, 200);
            this.listBox_DescendingLikeFriends.Name = "listBox_DescendingLikeFriends";
            this.listBox_DescendingLikeFriends.Size = new System.Drawing.Size(120, 212);
            this.listBox_DescendingLikeFriends.TabIndex = 0;
            // 
            // PictureBox_SelectedFriend
            // 
            this.PictureBox_SelectedFriend.Location = new System.Drawing.Point(175, 200);
            this.PictureBox_SelectedFriend.Name = "PictureBox_SelectedFriend";
            this.PictureBox_SelectedFriend.Size = new System.Drawing.Size(100, 86);
            this.PictureBox_SelectedFriend.TabIndex = 1;
            this.PictureBox_SelectedFriend.TabStop = false;
            // 
            // listBox_RecentPost
            // 
            this.listBox_RecentPost.FormattingEnabled = true;
            this.listBox_RecentPost.Location = new System.Drawing.Point(175, 317);
            this.listBox_RecentPost.Name = "listBox_RecentPost";
            this.listBox_RecentPost.Size = new System.Drawing.Size(200, 95);
            this.listBox_RecentPost.TabIndex = 2;
            // 
            // button_LikeBack
            // 
            this.button_LikeBack.Location = new System.Drawing.Point(300, 263);
            this.button_LikeBack.Name = "button_LikeBack";
            this.button_LikeBack.Size = new System.Drawing.Size(75, 23);
            this.button_LikeBack.TabIndex = 3;
            this.button_LikeBack.Text = "Like Back";
            this.button_LikeBack.UseVisualStyleBackColor = true;
            // 
            // LikeAnalyzerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 500);
            this.Controls.Add(this.button_LikeBack);
            this.Controls.Add(this.listBox_RecentPost);
            this.Controls.Add(this.PictureBox_SelectedFriend);
            this.Controls.Add(this.listBox_DescendingLikeFriends);
            this.Name = "LikeAnalyzerForm";
            this.Text = "Like Analyzer ";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_SelectedFriend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_DescendingLikeFriends;
        private System.Windows.Forms.PictureBox PictureBox_SelectedFriend;
        private System.Windows.Forms.ListBox listBox_RecentPost;
        private System.Windows.Forms.Button button_LikeBack;
    }
}