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
using Google.Apis.YouTube.v3;
using Google.Apis.Services;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FacebookApplication
{
    public partial class MusicForm : Form
    {
        //MusicForm m_MusicForm;
        User m_LoggedUser;
        List<Page> m_pagesList;
        YouTubeClass m_youTubeSearchObject;
        string m_musicainSelected;
        string m_videoId;
        string m_pageUrl;
        private string m_youTubeChannelLink = "https://www.youtube.com/channel/";
        private string m_youTubeVideoLink = "https://www.youtube.com/watch?v=";

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

        

        private async void ListBoxMusicans_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxMusicianVideos.Items.Clear();
            
            Page selectedPage = ListBoxMusicans.SelectedItem as Page;
            if (selectedPage != null)
            {
                musicianImage.LoadAsync(selectedPage.PictureLargeURL);
                m_musicainSelected = selectedPage.Name;

                string pageLikes = "Page Likes: ";
                labelPageLikes.Text = pageLikes + "\n\n" + selectedPage.LikesCount.ToString();
                m_pageUrl = selectedPage.URL;
            }

            if (m_youTubeSearchObject == null)
            {
                m_youTubeSearchObject = new YouTubeClass();
            }
            else
            {
                m_youTubeSearchObject.m_musicianVideos.Clear();
            }

            try
            {
                await m_youTubeSearchObject.YouTubeSearch(m_musicainSelected);
                if (string.IsNullOrEmpty(m_youTubeSearchObject.m_musicianChannelID))
                {
                    //TODO: change
                    buttonYouTubeChannel.Enabled = false;

                }
            }
            catch (AggregateException errors)
            {
                foreach (Exception a in errors.InnerExceptions)
                {
                    MessageBox.Show("Error: " + a.Message);
                }
            }
            catch (SystemException sysError)
            {
                MessageBox.Show("Error: " + sysError.Message);

            }

            fetchMusicianVideos();

        }

        private void buttonYouTubeChannel_Click(object sender, EventArgs e)
        {
            Process.Start(m_youTubeChannelLink + m_youTubeSearchObject.m_musicianChannelID);
        }


        private void fetchMusicianVideos()
        {
            ListBoxMusicianVideos.Items.Clear();

            if (m_youTubeSearchObject.m_musicianVideos.Count == 0)
            {
                MessageBox.Show("No Videos to retrieve :(");
            }

            foreach (Tuple<string,string> tuple in m_youTubeSearchObject.m_musicianVideos)
            {
                ListBoxMusicianVideos.DisplayMember = "tuple.Item1";
                ListBoxMusicianVideos.Items.Add(tuple);
            }

        }

        
        
        private void ListBoxMusicianVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tuple<string, string> selectedItem = ListBoxMusicianVideos.SelectedItem as Tuple<string, string>;
            m_videoId = selectedItem.Item2;
        }

        private void buttonPlayVideoOnYouTube_Click(object sender, EventArgs e)
        {
            if (m_videoId == null)
            {
                MessageBox.Show("Please Choose a Video From the List");
            }
            else
            {
                Process.Start(m_youTubeVideoLink + m_videoId);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLinkToPage_Click(object sender, EventArgs e)
        {
            if (m_pageUrl != null)
            {
                Process.Start(m_pageUrl);                
            }
        } 

    }
}
