using System.Collections;
using System.Collections.Generic;
using SyskenTLib.UtilForiOS.CameraLight;
using UnityEngine;

namespace SyskenTLib.UtilForiOS.Demo
{
    public class DemoManager : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }


        public void TurnLightOn()
        {
            DeviceLightManager deviceLightManager = new DeviceLightManager();
            deviceLightManager.TurnLight(true);
        }
        
        public void TurnLightOff()
        {
            DeviceLightManager deviceLightManager = new DeviceLightManager();
            deviceLightManager.TurnLight(false);
        }
    }
}
