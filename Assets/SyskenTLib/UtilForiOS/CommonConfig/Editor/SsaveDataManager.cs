using System;
using System.IO;
using UnityEngine;

namespace SyskenTLib.UtilForiOS.CommonConfig.Editor
{
    public class SsaveDataManager
    {
        
     private readonly string SAVE_DIR_PATH = "/SyskenTLib/UtilForiOS";
     private readonly string SAVE_FILE_NAME = "0_config.json";

     
        
        private string GetCurrentDate()
        {
            DateTime nowTime = DateTime.Now;
            return nowTime.ToString("yyyyMMddHHmmss");
        }
        
       
        #region プロジェクトに対しての保存
        
        private string GetProjectCommonConfigDirPath()
        {
            return Application.dataPath + SAVE_DIR_PATH;
        }

        private string GetProjectCommonConfigFilePath()
        {
            return GetProjectCommonConfigDirPath()+"/" + SAVE_FILE_NAME;
        }
        
        
        
        public bool IsExistProjectCommonConfig()
        {
            if (File.Exists(GetProjectCommonConfigFilePath()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public SaveDataJSON ReadProjectCommonConfig()
        {
            if (Directory.Exists(GetProjectCommonConfigDirPath())==false)
            {
                //ディレクトリが存在しなかったとき
                Directory.CreateDirectory(GetProjectCommonConfigDirPath());//ディレクトリ作成
            }

            if (IsExistProjectCommonConfig())
            {
                //設定ファイルがあった場合
                
                string savedText = File.ReadAllText(GetProjectCommonConfigFilePath());
                return JsonUtility.FromJson<SaveDataJSON>(savedText);
            }

            return new SaveDataJSON();//初期設定

        }
        
        
        public void SaveProjectCommonConfig(SaveDataJSON saveJSON)
        {
            string saveValue = GetCurrentDate();

            saveJSON.saveDateText = saveValue;
            
            string jsonText  = JsonUtility.ToJson (saveJSON,true);

            if (Directory.Exists(GetProjectCommonConfigDirPath())==false)
            {
                //ディレクトリが存在しなかったとき
                Directory.CreateDirectory(GetProjectCommonConfigDirPath());//ディレクトリ作成
            }
            
            //ファイル保存
            File.WriteAllText(GetProjectCommonConfigFilePath(), jsonText);


        }
        
        public void RemoveProjectCommon()
        {
            File.Delete(GetProjectCommonConfigFilePath());
        }
        
        #endregion
    }
}