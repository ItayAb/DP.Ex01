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

        private List<Tuple<string, string>> m_YouTubeSearchResult;
        private List<YouTubeVideo> m_YouTubeVideoList;

        private readonly string r_youTubeChannelLink = "https://www.youtube.com/channel/";
        private readonly string r_youTubeVideoLink = "https://www.youtube.com/watch?v=";
        private readonly string r_youTubeVideoLinkForPlayer = "https://www.youtube.com/v/";

        public string Musician { get; set; }


        public List<YouTubeVideo> YouTubeVideoList
        {
            get {
               
                SearchProxy();
                
                return m_YouTubeVideoList;
            }

            set 
            {
               m_YouTubeVideoList = value;   
            }
        }
        
        public void SearchProxy()
        {
            //check if the Dictionary was initilized
            if (m_CacheVideos == null)
            {
                m_CacheVideos = new Dictionary<string, List<YouTubeVideo>>();
            }

            if (m_CacheVideos.ContainsKey(Musician))
            {
                m_YouTubeVideoList = m_CacheVideos[Musician];
            }
            else
            {
                //Thread searchTread = new Thread(() => searchYouTube());
                //searchTread.Start();
                //searchTread.Join();
                searchYouTube();

                //Thread updateThread = new Thread(() => updateCached());
                //updateThread.Start();
                //updateThread.Join();
                updateCached();

                if (m_CacheVideos.ContainsKey(Musician))
                {
                    m_YouTubeVideoList = m_CacheVideos[Musician];
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
                
                if (m_YouTubeSearchResult != null)
	            {
                    m_YouTubeSearchResult.Clear();
	            }
            }

            try
            {
                m_YouTubeSearchObject.YouTubeSearch(Musician);
                
                m_YouTubeSearchResult = new List<Tuple<string, string>>(m_YouTubeSearchObject.getMusicianVideos);

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
                foreach (Tuple<string, string> v in m_YouTubeSearchResult)
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

            try
            {
                if (videoList.Count > 0)
                {
                    m_CacheVideos.Add(Musician, videoList);
                }
            }
            catch (ArgumentException)
            {
                Console.Error.WriteLine("Multiply Key Error, Same Video Name");
            } 
        }
    }
}
