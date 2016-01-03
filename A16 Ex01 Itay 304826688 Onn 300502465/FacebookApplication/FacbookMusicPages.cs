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
        private List<Page> m_MusicPagesList;

        

        public FacbookMusicPages(User i_LoggedUser)
        {
            m_LoggedUser = i_LoggedUser;
        }
        

        public void fetch()
        {
            m_MusicPagesList = new List<Page>();

            foreach (Page page in m_LoggedUser.LikedPages)
            {
                if (page.Category == "Musician/Band")
                {
                    m_MusicPagesList.Add(page);
                }
            }
        }

        public object get()
        {
            return m_MusicPagesList;
        }
    }
}