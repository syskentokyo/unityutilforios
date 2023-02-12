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
                SsaveDataManager ssaveDataManager = new SsaveDataManager();
                SaveDataJSON currentConfigJSON = ssaveDataManager.ReadProjectCommonConfig();



                string plistPath = path + "/Info.plist";
                var plist = new PlistDocument();
                plist.ReadFromString(File.ReadAllText(plistPath));
                
                if (currentConfigJSON.isOverrideCameraUsage){
                    plist.root.SetString("NSCameraUsageDescription", currentConfigJSON.cameraUsageDescription);
                }

                if (currentConfigJSON.isOverrideLocationWhenAlwaysAndUseUsage){
                    plist.root.SetString("NSLocationAlwaysAndWhenInUseUsageDescription", currentConfigJSON.locationUsageWhenAlwaysAndUseDescription);
                }
                
                if (currentConfigJSON.isOverrideLocationWhenUseUsage){
                    plist.root.SetString("NSLocationWhenInUseUsageDescription", currentConfigJSON.locationUsageWhenUseDescription);
                }
                
                if (currentConfigJSON.isOverrideLocationWhenAlwaysUsage){
                    plist.root.SetString("NSLocationAlwaysUsageDescription", currentConfigJSON.locationUsageWhenAlwaysDescription);
                }
                
                if (currentConfigJSON.isOverrideLocalNetworkUsage){
                    plist.root.SetString("NSLocalNetworkUsageDescription", currentConfigJSON.localNetworkUsageDescription);
                }
                
                if (currentConfigJSON.isOverrideBluetoothAlwaysUsage){
                    plist.root.SetString("NSBluetoothAlwaysUsageDescription", currentConfigJSON.bluetoothAlwaysUsageDescription);
                }
                
                if (currentConfigJSON.isOverrideNFCScanUsage){
                    plist.root.SetString("NFCReaderUsageDescription", currentConfigJSON.nfcScanUsageDescription);
                }
                
                if (currentConfigJSON.isOverridePhotoLibraryAddUsage){
                    plist.root.SetString("NSPhotoLibraryAddUsageDescription", currentConfigJSON.photoLibraryAddUsageDescription);
                }
                
                if (currentConfigJSON.isOverridePhotoLibraryUsage){
                    plist.root.SetString("NSPhotoLibraryUsageDescription", currentConfigJSON.photoLibraryUsageDescription);
                }
                
                
                //InfoPlist保存
                File.WriteAllText(plistPath, plist.WriteToString());
            }
        }
    }
}