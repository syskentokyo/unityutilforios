using System.IO;
using SyskenTLib.UtilForiOS.CommonConfig.Editor;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEditor.Callbacks;
using UnityEngine;

#if UNITY_IOS
using UnityEditor.iOS.Xcode;
#endif

namespace SyskenTLib.UtilForiOS.InfoPlistConfig.Editor
{
    public class AutoInfoPlistSettingPostProcessor
    {
        
        [PostProcessBuild]
        public static void OnPostProcessBuild(BuildTarget buildTarget, string path)
        {

            if (buildTarget == BuildTarget.iOS)
            {
                SaveDataManager saveDataManager = new SaveDataManager();
                SyskenTLibUtilForiOSConfig config = saveDataManager.GetConfig();

                string logTxt = "InfoPlist書き換え\n";


                string plistPath = path + "/Info.plist";
                var plist = new PlistDocument();
                plist.ReadFromString(File.ReadAllText(plistPath));
                
                if (config.isOverrideCameraUsage){
                    plist.root.SetString("NSCameraUsageDescription", config.cameraUsageDescription);
                    logTxt += "NSCameraUsageDescription " + config.cameraUsageDescription + "\n";
                }

                if (config.isOverrideLocationWhenAlwaysAndUseUsage){
                    plist.root.SetString("NSLocationAlwaysAndWhenInUseUsageDescription", config.locationUsageWhenAlwaysAndUseDescription);
                    logTxt += "NSLocationAlwaysAndWhenInUseUsageDescription " + config.locationUsageWhenAlwaysAndUseDescription + "\n";
                }
                
                if (config.isOverrideLocationWhenUseUsage){
                    plist.root.SetString("NSLocationWhenInUseUsageDescription", config.locationUsageWhenUseDescription);
                    logTxt += "NSLocationWhenInUseUsageDescription " + config.locationUsageWhenUseDescription + "\n";
                }
                
                if (config.isOverrideLocationWhenAlwaysUsage){
                    plist.root.SetString("NSLocationAlwaysUsageDescription", config.locationUsageWhenAlwaysDescription);
                    logTxt += "NSLocationAlwaysUsageDescription " + config.locationUsageWhenAlwaysDescription + "\n";
                }
                
                if (config.isOverrideLocalNetworkUsage){
                    plist.root.SetString("NSLocalNetworkUsageDescription", config.localNetworkUsageDescription);
                    logTxt += "NSLocalNetworkUsageDescription " + config.localNetworkUsageDescription + "\n";
                }
                
                if (config.isOverrideBluetoothAlwaysUsage){
                    plist.root.SetString("NSBluetoothAlwaysUsageDescription", config.bluetoothAlwaysUsageDescription);
                    logTxt += "NSBluetoothAlwaysUsageDescription " + config.bluetoothAlwaysUsageDescription + "\n";
                }
                
                if (config.isOverrideNFCScanUsage){
                    plist.root.SetString("NFCReaderUsageDescription", config.nfcScanUsageDescription);
                    logTxt += "NFCReaderUsageDescription " + config.nfcScanUsageDescription + "\n";
                }
                
                if (config.isOverridePhotoLibraryAddUsage){
                    plist.root.SetString("NSPhotoLibraryAddUsageDescription", config.photoLibraryAddUsageDescription);
                    logTxt += "NSPhotoLibraryAddUsageDescription " + config.photoLibraryAddUsageDescription + "\n";
                }
                
                if (config.isOverridePhotoLibraryUsage){
                    plist.root.SetString("NSPhotoLibraryUsageDescription", config.photoLibraryUsageDescription);
                    logTxt += "NSPhotoLibraryUsageDescription " + config.photoLibraryUsageDescription + "\n";
                }
                
                if (config.isOverrideEnableOpenFileFromFinder){
                    plist.root.SetBoolean("UIFileSharingEnabled",true);
                    plist.root.SetBoolean("LSSupportsOpeningDocumentsInPlace",true);
                    logTxt += "UIFileSharingEnabled " + "true" + "\n";
                    logTxt += "LSSupportsOpeningDocumentsInPlace " + "true" + "\n";
                }
                
                Debug.Log(logTxt);
                
                //InfoPlist保存
                File.WriteAllText(plistPath, plist.WriteToString());
            }
        }
    }
}