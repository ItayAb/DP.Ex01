using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;


namespace FacebookApplication
{
    class FacbookMusicPages : IFetchMusicData<Page>
    {
        private User m_LoggedUserAdoptee;
        private List<Page> m_MusicPagesList;

        public FacbookMusicPages(User i_LoggedUser)
        {
            m_LoggedUserAdoptee = i_LoggedUser;
        }
        
       
        public List<Page> fetch()
        {
            m_MusicPagesList = new List<Page>();

            foreach (Page page in m_LoggedUserAdoptee.LikedPages)
            {
                if (page.Category == "Musician/Band")
                {
                    m_MusicPagesList.Add(page);
                }
            }

            return m_MusicPagesList;
        }
    }
}