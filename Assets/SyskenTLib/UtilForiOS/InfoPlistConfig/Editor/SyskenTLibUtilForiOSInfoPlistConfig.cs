using UnityEngine;

namespace SyskenTLib.UtilForiOS.InfoPlistConfig.Editor
{

    public class SyskenTLibUtilForiOSInfoPlistConfig : ScriptableObject
    {

        [Header("InfoPlist ")]
        [Header("Camera")]
        public bool isOverrideCameraUsage = false;
        public string cameraUsageDescription = "";
        
        [Header("Location - Always And Use")]
        public bool isOverrideLocationWhenAlwaysAndUseUsage = false;
        public string locationUsageWhenAlwaysAndUseDescription = "";
        
        [Header("Location - Use")]
        public bool isOverrideLocationWhenUseUsage = false;
        public string locationUsageWhenUseDescription = "";
        
        [Header("Location - Always")]
        public bool isOverrideLocationWhenAlwaysUsage = false;
        public string locationUsageWhenAlwaysDescription = "";
        
        [Header("LocalNetwork")]
        public bool isOverrideLocalNetworkUsage = false;
        public string localNetworkUsageDescription = "";
        
        [Header("Bluetooth")]
        public bool isOverrideBluetoothAlwaysUsage = false;
        public string bluetoothAlwaysUsageDescription = "";
        
        [Header("NFC")]
        public bool isOverrideNFCScanUsage = false;
        public string nfcScanUsageDescription = "";
        
        [Header("Photo")]
        [Header("Photo - Add")]
        public bool isOverridePhotoLibraryAddUsage = false;
        public string photoLibraryAddUsageDescription = "";
        
        [Header("Photo - Use")]
        public bool isOverridePhotoLibraryUsage = false;
        public string photoLibraryUsageDescription = "";
        
        [Header("Finder")]
        public bool isOverrideEnableOpenFileFromFinder = false;
    }
}