using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FacebookApplication
{
    class SaveLoadUtil
    {

        public static bool SaveAppData(string i_pathToSave, ApplicationConfigurationData i_AppData)
        {
            bool resultOfSaveOperation = false;

            try
            {
                StreamWriter dataWriter = new StreamWriter(i_pathToSave);
                dataWriter.WriteLine(i_AppData.AccessToken);
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
                    string data = dataReader.ReadToEnd();
                    if (!string.IsNullOrEmpty(data))
                    {
                        i_AppData.AccessToken = data;
                        resultOfLoad = true;                        
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
