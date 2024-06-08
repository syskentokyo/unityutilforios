using System.Runtime.InteropServices;

namespace SyskenTLib.UtilForiOS.OpenMySettingApp
{
    public class OSNativeOpenMySettingAppBridge
    {
       
#if UNITY_IOS
        [DllImport("__Internal", EntryPoint = "SyskenTlibOpenMySettingAppOpenMySettingApp")]
        private static extern bool SyskenTlibOpenMySettingApp();
        
#endif

        public void OpenMySettingApp()
        {
#if UNITY_IOS
            SyskenTlibOpenMySettingApp();
#endif
        }
        
    }
}