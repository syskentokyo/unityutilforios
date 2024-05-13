using System;
using System.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

namespace SyskenTLib.UtilForiOS.Vibrate
{
    public class OSNativeVibrateBridge
    {

        [DllImport("__Internal", EntryPoint = "SyskenTlibVibratePrepareVibrate")]
        private static extern bool SyskenTlibVibratePrepareVibrate(int groupID,int typeID);
        
        [DllImport("__Internal", EntryPoint = "SyskenTlibVibratePlayVibrate")]
        private static extern bool SyskenTlibVibratePlayVibrate(int groupID,int typeID,int strength);



        public void PrepareVibrate(int groupID, int typeID)
        {
            SyskenTlibVibratePrepareVibrate(groupID, typeID);
        }
        
        public void PlayVibrate(int groupID, int typeID,int strength)
        {
            SyskenTlibVibratePlayVibrate(groupID, typeID,strength);
        }
    }
}