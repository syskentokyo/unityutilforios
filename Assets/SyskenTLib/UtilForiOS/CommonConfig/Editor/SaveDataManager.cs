using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace SyskenTLib.UtilForiOS.CommonConfig.Editor
{
    public class SaveDataManager
    {
        public SyskenTLibUtilForiOSConfig GetConfig()
        {
            return SearchConfigFile();
        }

        private SyskenTLibUtilForiOSConfig SearchConfigFile()
        {
            List<SyskenTLibUtilForiOSConfig> configList = new List<SyskenTLibUtilForiOSConfig>();
#if UNITY_EDITOR
            string[] guids = AssetDatabase.FindAssets("t:SyskenTLibUtilForiOSConfig");
            guids.ToList().ForEach(nextGUID =>
            {
                string filePath = AssetDatabase.GUIDToAssetPath(nextGUID);
                configList.Add( AssetDatabase.LoadAssetAtPath<SyskenTLibUtilForiOSConfig> (filePath));
                
            });
#endif
            return configList[0];
        }

     
        
    }
}