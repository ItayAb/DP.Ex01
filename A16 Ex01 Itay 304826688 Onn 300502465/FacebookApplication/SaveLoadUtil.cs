using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FacebookApplication
{

    // TODO : should use reflection or serializer?
    class SaveLoadUtil
    {

        public static bool SaveAppData(string i_pathToSave, ApplicationConfigurationData i_AppData)
        {
            bool resultOfSaveOperation = false;

            try
            {
                StreamWriter dataWriter = new StreamWriter(i_pathToSave);
                dataWriter.WriteLine(i_AppData.AccessToken);
                dataWriter.WriteLine(i_AppData.RememberMe);
                dataWriter.Flush();
                dataWriter.Close();
                resultOfSaveOperation = true;
            }
            catch (Exception e)
            {                
                throw e;
            }

            return resultOfSaveOperation;
        }

        public static bool LoadAppData(string i_PathToLoad, ApplicationConfigurationData i_AppData)
        {
            bool resultOfLoad = false;

            if (File.Exists(i_PathToLoad))
            {
                try
                {
                    StreamReader dataReader = new StreamReader(i_PathToLoad);
                    string AppDataAccessToken = dataReader.ReadLine();
                    string AppDataRememberMe = dataReader.ReadLine();
                    if (!string.IsNullOrEmpty(AppDataAccessToken))
                    {
                        i_AppData.AccessToken = AppDataAccessToken;

                        if (!string.IsNullOrEmpty(AppDataRememberMe))
                        {
                            i_AppData.RememberMe = AppDataRememberMe.ToLower().Equals("true") ? true : false;
                            resultOfLoad = true;                        
                        }
                    }

                    dataReader.Close();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            return resultOfLoad;
        }
    }
}
