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
    public partial class MusicForm : Form
    {
        MusicForm m_MusicForm;
        User m_LoggedUser;
        List<Page> m_pagesList;
        
        public MusicForm(User i_LoggedUser)
        {
            InitializeComponent();
            if (i_LoggedUser != null)
            {
                m_LoggedUser = i_LoggedUser;
                m_pagesList = new List<Page>();
                initMusicForm();
            }
        }

        public User LoggedUser
        {
            get
            {
                return m_LoggedUser;
            }

            set
            {
                m_LoggedUser = value;
            }
        }


        private void initMusicForm()
        {
            profileName.Text = "Hello " + m_LoggedUser.Name;
            profileImage.LoadAsync(m_LoggedUser.PictureNormalURL);
        }
        


        // fetches the pages and filtring the pages of Musicians
        private void fetchPages()
        {
            ListBoxMusicans.Items.Clear();

            if (m_LoggedUser.LikedPages.Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve :(");
            }

            ListBoxMusicans.DisplayMember = "Name";

            foreach (Page p in m_LoggedUser.LikedPages)
            {
                if (p.Category == "Musician/Band")
                {
                    ListBoxMusicans.Items.Add(p);

                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MusicForm_Load(object sender, EventArgs e)
        {

        }

        private void profileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void profileImage_Click(object sender, EventArgs e)
        {

        }

        private void buttonFetchMusic_Click(object sender, EventArgs e)
        {
            fetchPages();
        }

        private void ListBoxMusicans_SelectedIndexChanged(object sender, EventArgs e)
        {
            Page selectedPage = ListBoxMusicans.SelectedItem as Page;
            if (selectedPage != null)
            {
                musicianImage.LoadAsync(selectedPage.PictureLargeURL);
            }   

        }

    }
}
