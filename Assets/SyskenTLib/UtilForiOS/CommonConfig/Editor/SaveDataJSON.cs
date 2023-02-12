using System;

namespace SyskenTLib.UtilForiOS.CommonConfig.Editor
{
    [Serializable]
    public class SaveDataJSON
    {

        public string saveDateText = "";
        
        public bool isAutoTurnAffBitCode = false;



        public bool isOverrideCameraUsage = false;
        public string cameraUsageDescription = "";
        
        public bool isOverrideLocationWhenAlwaysAndUseUsage = false;
        public string locationUsageWhenAlwaysAndUseDescription = "";
        
        public bool isOverrideLocationWhenUseUsage = false;
        public string locationUsageWhenUseDescription = "";
        
        public bool isOverrideLocationWhenAlwaysUsage = false;
        public string locationUsageWhenAlwaysDescription = "";
        
        public bool isOverrideLocalNetworkUsage = false;
        public string localNetworkUsageDescription = "";
        
        public bool isOverrideBluetoothAlwaysUsage = false;
        public string bluetoothAlwaysUsageDescription = "";
        
        public bool isOverrideNFCScanUsage = false;
        public string nfcScanUsageDescription = "";
        
        public bool isOverridePhotoLibraryAddUsage = false;
        public string photoLibraryAddUsageDescription = "";
        
        public bool isOverridePhotoLibraryUsage = false;
        public string photoLibraryUsageDescription = "";
    }
}