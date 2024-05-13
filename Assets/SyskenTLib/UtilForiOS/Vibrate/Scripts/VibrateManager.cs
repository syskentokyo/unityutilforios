namespace SyskenTLib.UtilForiOS.Vibrate
{
    public class VibrateManager
    {
        private OSNativeVibrateBridge _osNativeVibrateBridge = new OSNativeVibrateBridge();
        
        public void PrepareVibrate(int groupID, int typeID)
        {
            _osNativeVibrateBridge.PrepareVibrate(groupID, typeID);
        }
        
        public void PlayVibrate(int groupID, int typeID,int strength)
        {
            _osNativeVibrateBridge.PlayVibrate(groupID, typeID,strength);
        }
    }
}