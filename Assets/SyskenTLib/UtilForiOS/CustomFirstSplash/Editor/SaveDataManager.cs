using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;



namespace SyskenTLib.UtilForiOS.CustomFirstSplash.Editor
{
    public class SaveDataManager
    {
        public SyskenTLibUtilForiOSCustomFirstSplashConfig GetConfig()
        {
            return SearchConfigFile();
        }

        private SyskenTLibUtilForiOSCustomFirstSplashConfig SearchConfigFile()
        {
            List<SyskenTLibUtilForiOSCustomFirstSplashConfig> configList =
                new List<SyskenTLibUtilForiOSCustomFirstSplashConfig>();
#if UNITY_EDITOR
            string[] guids = AssetDatabase.FindAssets("t:SyskenTLibUtilForiOSCustomFirstSplashConfig");
            guids.ToList().ForEach(nextGUID =>
            {
                string filePath = AssetDatabase.GUIDToAssetPath(nextGUID);
                configList.Add(AssetDatabase.LoadAssetAtPath<SyskenTLibUtilForiOSCustomFirstSplashConfig>(filePath));

            });
#endif
            return configList[0];
        }



    }
}
