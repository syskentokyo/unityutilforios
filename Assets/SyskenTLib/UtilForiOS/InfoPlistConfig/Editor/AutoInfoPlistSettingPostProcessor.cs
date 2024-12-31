using System.IO;
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
                #if UNITY_IOS
                SaveDataManager saveDataManager = new SaveDataManager();
                SyskenTLibUtilForiOSInfoPlistConfig infoPlistConfig = saveDataManager.GetConfig();

                string logTxt = "InfoPlist書き換え\n";


                string plistPath = path + "/Info.plist";
                var plist = new PlistDocument();
                plist.ReadFromString(File.ReadAllText(plistPath));
                
                if (infoPlistConfig.isOverrideCameraUsage){
                    plist.root.SetString("NSCameraUsageDescription", infoPlistConfig.cameraUsageDescription);
                    logTxt += "NSCameraUsageDescription " + infoPlistConfig.cameraUsageDescription + "\n";
                }

                if (infoPlistConfig.isOverrideLocationWhenAlwaysAndUseUsage){
                    plist.root.SetString("NSLocationAlwaysAndWhenInUseUsageDescription", infoPlistConfig.locationUsageWhenAlwaysAndUseDescription);
                    logTxt += "NSLocationAlwaysAndWhenInUseUsageDescription " + infoPlistConfig.locationUsageWhenAlwaysAndUseDescription + "\n";
                }
                
                if (infoPlistConfig.isOverrideLocationWhenUseUsage){
                    plist.root.SetString("NSLocationWhenInUseUsageDescription", infoPlistConfig.locationUsageWhenUseDescription);
                    logTxt += "NSLocationWhenInUseUsageDescription " + infoPlistConfig.locationUsageWhenUseDescription + "\n";
                }
                
                if (infoPlistConfig.isOverrideLocationWhenAlwaysUsage){
                    plist.root.SetString("NSLocationAlwaysUsageDescription", infoPlistConfig.locationUsageWhenAlwaysDescription);
                    logTxt += "NSLocationAlwaysUsageDescription " + infoPlistConfig.locationUsageWhenAlwaysDescription + "\n";
                }
                
                if (infoPlistConfig.isOverrideLocalNetworkUsage){
                    plist.root.SetString("NSLocalNetworkUsageDescription", infoPlistConfig.localNetworkUsageDescription);
                    logTxt += "NSLocalNetworkUsageDescription " + infoPlistConfig.localNetworkUsageDescription + "\n";
                }
                
                if (infoPlistConfig.isOverrideBluetoothAlwaysUsage){
                    plist.root.SetString("NSBluetoothAlwaysUsageDescription", infoPlistConfig.bluetoothAlwaysUsageDescription);
                    logTxt += "NSBluetoothAlwaysUsageDescription " + infoPlistConfig.bluetoothAlwaysUsageDescription + "\n";
                }
                
                if (infoPlistConfig.isOverrideNFCScanUsage){
                    plist.root.SetString("NFCReaderUsageDescription", infoPlistConfig.nfcScanUsageDescription);
                    logTxt += "NFCReaderUsageDescription " + infoPlistConfig.nfcScanUsageDescription + "\n";
                }
                
                if (infoPlistConfig.isOverridePhotoLibraryAddUsage){
                    plist.root.SetString("NSPhotoLibraryAddUsageDescription", infoPlistConfig.photoLibraryAddUsageDescription);
                    logTxt += "NSPhotoLibraryAddUsageDescription " + infoPlistConfig.photoLibraryAddUsageDescription + "\n";
                }
                
                if (infoPlistConfig.isOverridePhotoLibraryUsage){
                    plist.root.SetString("NSPhotoLibraryUsageDescription", infoPlistConfig.photoLibraryUsageDescription);
                    logTxt += "NSPhotoLibraryUsageDescription " + infoPlistConfig.photoLibraryUsageDescription + "\n";
                }
                
                if (infoPlistConfig.isOverrideEnableOpenFileFromFinder){
                    plist.root.SetBoolean("UIFileSharingEnabled",true);
                    plist.root.SetBoolean("LSSupportsOpeningDocumentsInPlace",true);
                    logTxt += "UIFileSharingEnabled " + "true" + "\n";
                    logTxt += "LSSupportsOpeningDocumentsInPlace " + "true" + "\n";
                }
                
                Debug.Log(logTxt);
                
                //InfoPlist保存
                File.WriteAllText(plistPath, plist.WriteToString());
                
                #endif
            }
        }
    }
}
