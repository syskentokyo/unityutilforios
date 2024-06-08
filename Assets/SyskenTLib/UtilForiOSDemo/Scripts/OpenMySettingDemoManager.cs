using SyskenTLib.UtilForiOS.OpenMySettingApp;
using UnityEngine;

namespace SyskenTLib.UtilForiOS.Demo
{
    public class OpenMySettingDemoManager : MonoBehaviour
    {
        public void OnTouchedStartButton()
        {
            OpenMySettingAppManager openMySettingAppManager = new OpenMySettingAppManager();
            openMySettingAppManager.OpenMySettingApp();;
        }
    }
}