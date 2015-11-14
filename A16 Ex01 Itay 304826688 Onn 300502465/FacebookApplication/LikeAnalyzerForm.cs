using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookApplication
{
    public partial class LikeAnalyzerForm : Form
    {
        LikeAnalyzer m_LikeAnalyzer;
        User m_LoggedUser;

        public LikeAnalyzerForm(User i_LoggedUser)
        {
            InitializeComponent();
            m_LoggedUser = i_LoggedUser;
            textBox_AmountOfPosts.Text = m_LoggedUser.Posts.Count.ToString();
        }

        private void button_RunAnalysis_Click(object sender, EventArgs e)
        {
            
            int numOfPosts;
            m_LikeAnalyzer = new LikeAnalyzer(m_LoggedUser);
            if (int.TryParse(textBox_AmountPostsToParse.Text, out numOfPosts))
            {
                if (numOfPosts > m_LoggedUser.Posts.Count || numOfPosts < 1)
                {
                    MessageBox.Show(string.Format("The max value is {0}, min value is 0", m_LoggedUser.Posts.Count));
                    return;
                }
                m_LikeAnalyzer.calculateLikeToList(numOfPosts);
            }

            updateUI();
        }

        private void updateUI()
        {
            listBox_DescendingLikeFriends.Items.Clear();
            List<User> likers = m_LikeAnalyzer.GetDescendingTopLikeUserList();
            listBox_DescendingLikeFriends.DisplayMember = "Name";
            foreach (User likeUser in likers)
            {
                listBox_DescendingLikeFriends.Items.Add(likeUser);
               
            }
        }

        private void listBox_DescendingLikeFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            User selectedUser = listBox_DescendingLikeFriends.SelectedItem as User;
            if (selectedUser != null)
            {
                PictureBox_SelectedFriend.LoadAsync(selectedUser.PictureNormalURL);
                string amountOfLikesStr = m_LikeAnalyzer.GetAmountOfLikesByUser(selectedUser).ToString();
                textBox_AmountOfLikeForUser.Text = amountOfLikesStr;
                foreach (Post userLikerPosts in selectedUser.Posts)
                {
                    listBox_RecentPost.Items.Add(userLikerPosts.Message);
                }
            }
            
        }
    }
}
