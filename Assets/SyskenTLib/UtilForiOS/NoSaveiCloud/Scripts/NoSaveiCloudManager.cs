using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_IOS
using UnityEngine.iOS;
#endif


namespace SyskenTLib.UtilForiOS.NoSaveiCloud
{
    public class NoSaveiCloudManager 
    {


        public void SetNoSaveToiCloud(string dirPath){
            
#if UNITY_IOS
        
            Device.SetNoBackupFlag(dirPath);//iCloudへの保存しないようにする
            
#endif
        
        }


    }
}
