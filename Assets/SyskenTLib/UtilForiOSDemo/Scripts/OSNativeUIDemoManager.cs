using System.Collections;
using System.Collections.Generic;
using SyskenTLib.UtilForiOS.OSNativeUI;
using UnityEngine;

namespace SyskenTLib.UtilForiOS.Demo
{
    public class OSNativeUIDemoManager : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void OnTouchedShowAlertButton()
        {
            OSNativeAlertUIManager osNativeAlertUIManager = new OSNativeAlertUIManager();
            osNativeAlertUIManager.ShowAlert("タイトル","サブ","yes","no");
        }
    }
}
