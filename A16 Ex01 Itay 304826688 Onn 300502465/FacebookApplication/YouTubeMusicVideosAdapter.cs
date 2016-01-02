using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Google.Apis.YouTube.v3;
using Google.Apis.Services;
using YouTubeSearch;
using System.Threading;

namespace FacebookApplication
{
    class YouTubeMusicVideosAdapter : IFetchMusicData
    {
        private YouTubeClass m_YouTubeSearchObjectAdoptee;
        private String m_MusicianSelected;
        private List<YouTubeVideo> m_MusicYouTubeVideosList;
        private List<Tuple<string, string>> m_LegacyList;
        private string m_ChannelId;
        private readonly string r_youTubeVideoLink = "https://www.youtube.com/watch?v=";
        private readonly string r_youTubeVideoLinkForPlayer = "https://www.youtube.com/v/";
        private readonly string r_youTubeChannelLink = "https://www.youtube.com/channel/";

        public YouTubeMusicVideosAdapter(String i_MusicianSelected)
        {
            m_MusicianSelected = i_MusicianSelected;
          
        }

        public List<YouTubeVideo> YouTubeVideoList
        {
            get
            {
                return m_MusicYouTubeVideosList;
            }
        }

        
        /*
        public List<YouTubeVideo> fetch1sd()
        {
            // initate the youtube object
            if (m_YouTubeSearchObjectAdoptee == null)
            {
                m_YouTubeSearchObjectAdoptee = new YouTubeSearch.YouTubeClass();
            }
            else
            {
                m_YouTubeSearchObjectAdoptee.getMusicianVideos.Clear();
            }

            try
            {
                await m_YouTubeSearchObjectAdoptee.YouTubeSearch(m_MusicianSelected);

                Console.WriteLine("Finished Search");

                //m_LegacyList = m_YouTubeSearchObjectAdoptee.getMusicianVideos;


                /*
                // if the search not find the channel ID disable the button
                if (string.IsNullOrEmpty(m_YouTubeSearchObjectAdoptee.getMusicianChannelID))
                {
                    buttonYouTubeChannel.Enabled = false;
                }
                 
            }
            catch (AggregateException errors)
            {
                foreach (Exception error in errors.InnerExceptions)
                {

                }
            }

            m_ChannelId = m_YouTubeSearchObjectAdoptee.getMusicianChannelID;

            convertYouTubeList();

            return m_MusicYouTubeVideosList;
        }
            */
         

        private void convertYouTubeList()
        {
            if (m_MusicYouTubeVideosList == null)
            {
                m_MusicYouTubeVideosList = new List<YouTubeVideo>();
            }

            foreach (Tuple<string, string> video in m_YouTubeSearchObjectAdoptee.getMusicianVideos)
            {
                m_MusicYouTubeVideosList.Add(constructYouTubeVideoObject(video));
                Console.WriteLine("Added");
            }
        }

        private YouTubeVideo constructYouTubeVideoObject(Tuple<string, string> i_LegacyTuple)
        {
            YouTubeVideo youTubeVideoObject = new YouTubeVideo();
            youTubeVideoObject.VideoKey = i_LegacyTuple.Item2;
            youTubeVideoObject.VideoName = i_LegacyTuple.Item1;
            youTubeVideoObject.VideoUrl = r_youTubeVideoLink + i_LegacyTuple.Item2;
            youTubeVideoObject.VideoLinkForPlayer = r_youTubeVideoLinkForPlayer + i_LegacyTuple.Item2;
            youTubeVideoObject.YouTubeChannelUrl = r_youTubeChannelLink + m_ChannelId;

            return youTubeVideoObject;
        }

        private void searchYouTube()
        {
            
        }


        public void fetch()
        {

        }
        /*
        public async void fetch()
        {
            // initate the youtube object
            if (m_YouTubeSearchObjectAdoptee == null)
            {
                m_YouTubeSearchObjectAdoptee = new YouTubeSearch.YouTubeClass();
            }
            else
            {
                m_YouTubeSearchObjectAdoptee.getMusicianVideos.Clear();
            }

            try
            {
                await m_YouTubeSearchObjectAdoptee.YouTubeSearch(m_MusicianSelected);

                Console.WriteLine("Finished Search");

                //m_LegacyList = m_YouTubeSearchObjectAdoptee.getMusicianVideos;


                /*
                // if the search not find the channel ID disable the button
                if (string.IsNullOrEmpty(m_YouTubeSearchObjectAdoptee.getMusicianChannelID))
                {
                    buttonYouTubeChannel.Enabled = false;
                }
                 
            }
            catch (AggregateException errors)
            {
                foreach (Exception error in errors.InnerExceptions)
                {

                }
            }

            m_ChannelId = m_YouTubeSearchObjectAdoptee.getMusicianChannelID;

            convertYouTubeList();
        }
         */

        public object get()
        {
            return m_MusicYouTubeVideosList;
        }
    }
}
