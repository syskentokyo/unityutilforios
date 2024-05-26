using System;
using System.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

namespace SyskenTLib.UtilForiOS.Vibrate
{
    public class OSNativeVibrateBridge
    {

#if UNITY_IOS
        [DllImport("__Internal", EntryPoint = "SyskenTlibVibratePrepareVibrate")]
        private static extern bool SyskenTlibVibratePrepareVibrate(int groupID,int typeID);
        
        [DllImport("__Internal", EntryPoint = "SyskenTlibVibratePlayVibrate")]
        private static extern bool SyskenTlibVibratePlayVibrate(int groupID,int typeID,int strength);

#endif

        public void PrepareVibrate(int groupID, int typeID)
        {
#if UNITY_IOS
            SyskenTlibVibratePrepareVibrate(groupID, typeID);
#endif
        }
        
        public void PlayVibrate(int groupID, int typeID,int strength)
        {
#if UNITY_IOS
            SyskenTlibVibratePlayVibrate(groupID, typeID,strength);
#endif
        }
    }
}