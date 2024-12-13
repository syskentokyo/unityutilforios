
using SyskenTLib.UtilForiOS.CameraLight;
using UnityEngine;

namespace SyskenTLib.UtilForiOS.Demo
{
    public class DemoManager : MonoBehaviour
    {



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
