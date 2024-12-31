using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;


namespace SyskenTLib.UtilForiOS.NoBitcodeEditor
{
    public class SaveDataManager
    {
        public SyskenTLibUtilForiOSNoBitCodeConfig GetConfig()
        {
            return SearchConfigFile();
        }

        private SyskenTLibUtilForiOSNoBitCodeConfig SearchConfigFile()
        {
            List<SyskenTLibUtilForiOSNoBitCodeConfig> configList = new List<SyskenTLibUtilForiOSNoBitCodeConfig>();
#if UNITY_EDITOR
            string[] guids = AssetDatabase.FindAssets("t:SyskenTLibUtilForiOSNoBitCodeConfig");
            guids.ToList().ForEach(nextGUID =>
            {
                string filePath = AssetDatabase.GUIDToAssetPath(nextGUID);
                configList.Add( AssetDatabase.LoadAssetAtPath<SyskenTLibUtilForiOSNoBitCodeConfig> (filePath));
                
            });
#endif
            return configList[0];
        }

     
        
    }
}