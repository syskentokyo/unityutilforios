namespace SyskenTLib.UtilForiOS.OpenMySettingApp
{
    public class OpenMySettingAppManager
    {
        private OSNativeOpenMySettingAppBridge _osNativeOpenMySettingAppBridge = new OSNativeOpenMySettingAppBridge();
        
        /// <summary>
        /// アプリの設定を開く
        /// </summary>
        public void OpenMySettingApp()
        {
            _osNativeOpenMySettingAppBridge.OpenMySettingApp();;
        }
    }
}