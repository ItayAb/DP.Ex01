using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;


namespace FacebookApplication
{
    class FacbookMusicPages
    {
        private User m_LoggedUser;

        public List<Page> MusicPagesList { get; set; }

        public FacbookMusicPages(User i_LoggedUser)
        {
            m_LoggedUser = i_LoggedUser;
        }
        
        public void fetch()
        {
            MusicPagesList = new List<Page>();

            foreach (Page page in m_LoggedUser.LikedPages)
            {
                if (page.Category == "Musician/Band")
                {
                    MusicPagesList.Add(page);
                }
            }
        }
    }
}