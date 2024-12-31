using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace SyskenTLib.UtilForiOS.InfoPlistConfig.Editor
{
    public class SaveDataManager
    {
        public SyskenTLibUtilForiOSInfoPlistConfig GetConfig()
        {
            return SearchConfigFile();
        }

        private SyskenTLibUtilForiOSInfoPlistConfig SearchConfigFile()
        {
            List<SyskenTLibUtilForiOSInfoPlistConfig> configList = new List<SyskenTLibUtilForiOSInfoPlistConfig>();
#if UNITY_EDITOR
            string[] guids = AssetDatabase.FindAssets("t:SyskenTLibUtilForiOSInfoPlistConfig");
            guids.ToList().ForEach(nextGUID =>
            {
                string filePath = AssetDatabase.GUIDToAssetPath(nextGUID);
                configList.Add( AssetDatabase.LoadAssetAtPath<SyskenTLibUtilForiOSInfoPlistConfig> (filePath));
                
            });
#endif
            return configList[0];
        }

     
        
    }
}