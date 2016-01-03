using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeSearch;
using System.Threading;

namespace FacebookApplication
{
    class YouTubeProxy
    {
        private Dictionary<string, List<YouTubeVideo>> m_CacheVideos;

        private YouTubeClass m_YouTubeSearchObject;

        private string m_Musician;

        private readonly string r_youTubeChannelLink = "https://www.youtube.com/channel/";
        private readonly string r_youTubeVideoLink = "https://www.youtube.com/watch?v=";
        private readonly string r_youTubeVideoLinkForPlayer = "https://www.youtube.com/v/";

        public List<YouTubeVideo> YouTubeVideoList { get; set; }

        public void SearchProxy(string i_Musician)
        {
            m_Musician = i_Musician;
            List<YouTubeVideo> result = new List<YouTubeVideo>();
            //check if the Dictionary was initilized
            if (m_CacheVideos == null)
            {
                m_CacheVideos = new Dictionary<string, List<YouTubeVideo>>();
            }

            if (m_CacheVideos.ContainsKey(m_Musician))
            {
                result = m_CacheVideos[m_Musician];
            }
            else
            {
                searchYouTube();
                updateCached();

                if (m_CacheVideos.ContainsKey(m_Musician))
                {
                    YouTubeVideoList = m_CacheVideos[m_Musician];
                }
                else
                {
                    result = null;
                }
            }
        }



        private void searchYouTube()
        {
            // initate the youtube object
            if (m_YouTubeSearchObject == null)
            {
                m_YouTubeSearchObject = new YouTubeSearch.YouTubeClass();
            }
            else
            {
                m_YouTubeSearchObject.getMusicianVideos.Clear();
            }

            try
            {
                m_YouTubeSearchObject.YouTubeSearch(m_Musician);

                Console.WriteLine("Finished Search");

            }
            catch (Exception error)
            {
                Console.Error.Write(error);
            }

        }

        private void updateCached()
        {

            List<YouTubeVideo> videoList = new List<YouTubeVideo>();

            if (m_YouTubeSearchObject != null)
            {
                foreach (Tuple<string, string> v in m_YouTubeSearchObject.getMusicianVideos)
                {
                    YouTubeVideo videoToAdd = new YouTubeVideo();
                    videoToAdd.VideoKey = v.Item2;
                    videoToAdd.VideoName = v.Item1;
                    videoToAdd.VideoUrl = r_youTubeVideoLink + v.Item2;
                    videoToAdd.VideoLinkForPlayer = r_youTubeVideoLinkForPlayer + v.Item2;
                    videoToAdd.YouTubeChannelUrl = r_youTubeChannelLink + m_YouTubeSearchObject.getMusicianChannelID;

                    videoList.Add(videoToAdd);
                }
            }

            m_CacheVideos.Add(m_Musician, videoList);
        }

    }
}
