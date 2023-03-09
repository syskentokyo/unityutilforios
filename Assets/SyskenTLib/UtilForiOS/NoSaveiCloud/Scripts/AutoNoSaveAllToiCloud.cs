using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SyskenTLib.UtilForiOS.NoSaveiCloud
{
    public class AutoNoSaveAllToiCloud : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
#if UNITY_IOS
                //できるだけすべてオフにする
                NoSaveiCloudManager noSaveiCloudManager = new NoSaveiCloudManager();
                noSaveiCloudManager.SetNoSaveToiCloud(Application.persistentDataPath);//Documenetフォルダすべてを対象から外す

#endif
        }

    }
}
