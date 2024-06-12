
using System;
using System.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;
namespace SyskenTLib.UtilForiOS.OSNativeUI
{
    public class OSNativeAlertUIManager
    {
#if UNITY_IOS
        [DllImport("__Internal", EntryPoint = "SyskenTlibOSNativeUIShowAlert")]
        private static extern void SyskenTlibOSNativeUIShowAlert(String title,String subTitle,String okButtonName,String cancelButtonName);
#endif

        public void ShowAlert(String title,String subTitle,String okButtonName,String cancelButtonName)
        {
#if UNITY_IOS
            SyskenTlibOSNativeUIShowAlert(title, subTitle,okButtonName,cancelButtonName);
#endif
        }
        
        
    }
    
}