using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Diagnostics;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
//using Google.Apis.YouTube.v3;
//using Google.Apis.Services;
using YouTubeSearch;
using System.Threading;

namespace FacebookApplication
{
    public partial class MusicForm : Form
    {
        //private readonly string r_youTubeChannelLink = "https://www.youtube.com/channel/";
        //private readonly string r_youTubeVideoLink = "https://www.youtube.com/watch?v=";
        //private readonly string r_youTubeVideoLinkForPlayer = "https://www.youtube.com/v/";
        
        private User m_LoggedUser;
        
        private List<Page> m_PagesList;
        private YouTubeClass m_YouTubeSearchObject;
        
        private string m_MusicainSelected;
        
        //private string m_VideoId;
        private string m_PageUrl;
        private Thread m_Thread;
        private bool v_FormOpen;
        private FacebookObjectCollection<Page> m_MusicPages;

        // TODO: Facade or Adapter
        private IFetchMusicData m_FacebookMusicPages;

        private YouTubeProxy m_YouTubeProxy;

        public List<YouTubeVideo> VideosList { get; set; }

        /// <param name="i_LoggedUser"> get user object from the main form</param>
        public MusicForm(User i_LoggedUser)
        {
            InitializeComponent();

            v_FormOpen = true;

            if (i_LoggedUser != null)
            {
                m_LoggedUser = i_LoggedUser;
                m_PagesList = new List<Page>();

                m_FacebookMusicPages = new FacbookMusicPages(m_LoggedUser);
                m_YouTubeProxy = new YouTubeProxy();
                //VideosList = new List<YouTubeVideo>();
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

        // load the user profile picture and init welcome message
        private void initMusicForm()
        {
            profileName.Text = string.Format("Hello {0}", m_LoggedUser.Name);

            if (!string.IsNullOrEmpty(m_LoggedUser.PictureNormalURL))
            {
                profileImage.LoadAsync(m_LoggedUser.PictureNormalURL);
            }
        }

       /*
        // fetches the pages and filtring the pages of Musicians
        private void fetchPages()
        {
            foreach (Page page in m_LoggedUser.LikedPages)
            {
                if (page.Category == "Musician/Band")
                { 
                    //ListBoxMusicans.Invoke(new Action(() => m_MusicPages.Add(page)));
                    //musicPages.Add(page);
                    m_MusicPages.Add(page);
                }
            }

            // using lambda in oreder to return to main thread for the UI
            ListBoxMusicans.Invoke(new Action(() => pageBindingSource.DataSource = m_MusicPages));
            
        }
        */

        private void buttonFetchMusic_Click(object sender, EventArgs e)
        {
            if (m_LoggedUser == null)
            {
                MessageBox.Show("Please login to Facebook First...");
            }
            else
            {
                // Clear the Items in Music Box
                //ListBoxMusicans.Items.Clear();

                if (m_LoggedUser.LikedPages.Count == 0)
                {
                    MessageBox.Show("No liked pages to retrieve :( ");
                }

                // collect 
                m_FacebookMusicPages.fetch();
                pageBindingSource.DataSource = m_FacebookMusicPages.get();

                //Page select = pageBindingSource.Current as Page;
                //m_YouTubeVideos = new YouTubeMusicVideosAdapter(select.Name);
                //m_YouTubeVideos.fetch();
                //youTubeVideoListBindingSource.DataSource = m_YouTubeVideos;


                //youTubeMusicVideosAdapterBindingSource.DataSource = m_YouTubeVideos;

                //ListBoxMusicans.DisplayMember = "Name";
                //m_MusicPages = new FacebookObjectCollection<Page>();
                //Thread thread = new Thread(() => fetchPages());
                //thread.IsBackground = true;
                //thread.Start();
                //fetchPages();

                Page selected = pageBindingSource.Current as Page;

                //VideosList = m_YouTubeProxy.SearchProxy(selected.Name);



            }
        }

        
        /// <summary>
        /// async method that activate the youtube search and all the data necessary for the form buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxMusicans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ListBoxMusicans.Enabled = false;
            //ListBoxMusicianVideos.Items.Clear();

            Page selected = pageBindingSource.Current as Page;

            //VideosList = m_YouTubeProxy.SearchProxy(selected.Name);

            Page selectedPage = pageBindingSource.Current as Page;
                //ListBoxMusicans.SelectedItem as Page;
            
            
            //youTubeVideoListBindingSource.DataSource = m_YouTubeVideos.get();

            //TODO: Check if data source
            if (selectedPage != null)
            {
                m_MusicainSelected = selectedPage.Name;
                m_PageUrl = selectedPage.URL;
            }

            //m_YouTubeVideos = new YouTubeMusicVideosAdapter(m_MusicainSelected);
            //m_YouTubeVideos.fetch();

            // fill list


            //m_Thread = new Thread(() => searchYouTube());
            //m_Thread.IsBackground = true;
            //m_Thread.Start();


            //combine the other tread to the ui
            //Invoke(new Action(() => fetchMusicianVideos()));

            //ListBoxMusicans.Invoke(new Action(() => musicPages.Add(page)));

            //fetchMusicianVideos();
            //ListBoxMusicans.Enabled = true;
        }

     

        /*        
        private async void searchYouTube()
        {
            // initate the youtube object
            if (m_YouTubeSearchObject == null)
            {
                m_YouTubeSearchObject = new YouTubeClass();
            }
            else
            {
                m_YouTubeSearchObject.getMusicianVideos.Clear();
            }

            try
            {
                await m_YouTubeSearchObject.YouTubeSearch(m_MusicainSelected);

                // if the search not find the channel ID disable the button
                if (string.IsNullOrEmpty(m_YouTubeSearchObject.getMusicianChannelID))
                {
                    buttonYouTubeChannel.Enabled = false;
                }

                fetchMusicianVideos();
            }
            catch (AggregateException errors)
            {
                foreach (Exception error in errors.InnerExceptions)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
         */ 
        

        private void buttonYouTubeChannel_Click(object sender, EventArgs e)
        {
            /*
            if (m_YouTubeSearchObject == null)
            {
                MessageBox.Show("Please Choose a Musician Page First");
            }
            else
            {
                Process.Start(string.Format("{0}{1}", r_youTubeChannelLink, m_YouTubeSearchObject.getMusicianChannelID));
            }
             */
        }


        
        /// <summary>
        /// get the top videos of the musician from youtube and reflect the resultes to the user
        /// </summary>
        private void fetchMusicianVideos()
        {
            if (v_FormOpen)
            {
                Invoke(new Action(() => ListBoxMusicianVideos.Items.Clear()));
                //ListBoxMusicianVideos.Items.Clear();

                if (m_YouTubeSearchObject.getMusicianVideos.Count == 0)
                {
                    MessageBox.Show("No Videos to retrieve :(");
                }
                else
                {
                    try
                    {
                        foreach (Tuple<string, string> tuple in m_YouTubeSearchObject.getMusicianVideos)
                        {
                            Invoke(new Action(() => ListBoxMusicianVideos.DisplayMember = "tuple.Item1"));
                            Invoke(new Action(() => ListBoxMusicianVideos.Items.Add(tuple)));

                            //ListBoxMusicianVideos.DisplayMember = "tuple.Item1";
                            //ListBoxMusicianVideos.Items.Add(tuple);
                        }
                    } catch
                    {
                        // if the user selected an artist and the UI need to update with the new selected item
                        return;
                    }
                }
            }
        }
         

        /// <summary>
        /// each time the user select a video the video id changes for the play button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxMusicianVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            Tuple<string, string> selectedItem = ListBoxMusicianVideos.SelectedItem as Tuple<string, string>;
            m_VideoId = selectedItem.Item2;
            ShockwaveFlashPlayerBox.Movie = string.Format("{0}{1}", r_youTubeVideoLinkForPlayer, m_VideoId);
             */
        }

        private void buttonPlayVideoOnYouTube_Click(object sender, EventArgs e)
        {
            /*
            if (m_VideoId == null)
            {
                MessageBox.Show("Please Choose a Video From the List");
            }
            else
            {
                Process.Start(string.Format("{0}{1}", r_youTubeVideoLink, m_VideoId));
            }
             */
        }

        private void buttonLinkToPage_Click(object sender, EventArgs e)
        {
            /*
            if (m_PageUrl == null)
            {
                MessageBox.Show("Please Choose a Music Page From The List");
            }
            else
            {
                Process.Start(m_PageUrl);
            }
             */
        }
        
        private void MusicForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            v_FormOpen = false;

        }
        
    }
}
