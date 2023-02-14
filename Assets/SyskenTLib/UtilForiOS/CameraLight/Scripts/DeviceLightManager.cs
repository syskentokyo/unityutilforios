using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace SyskenTLib.UtilForiOS.CameraLight
{
    public class DeviceLightManager
    {

        [DllImport("__Internal")]
        private static extern void UtilForiOS_TurnDeviceLightOn();
        
        [DllImport("__Internal")]
        private static extern void UtilForiOS_TurnDeviceLightOff();



        public void TurnLight(bool isOn)
        {
            if (isOn)
            {
                UtilForiOS_TurnDeviceLightOn();
            }
            else
            {
                UtilForiOS_TurnDeviceLightOff();
            }
        }
        

    }
}
