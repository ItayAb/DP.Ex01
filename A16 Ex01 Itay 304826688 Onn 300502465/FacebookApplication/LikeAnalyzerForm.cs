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

        public LikeAnalyzerForm(User i_LoggedUser)
        {
            InitializeComponent();
            m_LikeAnalyzer = new LikeAnalyzer(i_LoggedUser);
        }

        private void initAnaylysis()
        {
           
        
        }

        private void updateUIWithUserInfo() 
        {
            List<User> topLikers = m_LikeAnalyzer.GetDescendingTopLikeUserList();

            foreach (User currentTopLikeUser in topLikers)
            {
                listBox_DescendingLikeFriends.Items.Add(currentTopLikeUser);
            }
        }

        private void button_RunAnaylsis_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Calculating Posts"));
            m_LikeAnalyzer.CalculateLikeToList();
        }
    }
}
