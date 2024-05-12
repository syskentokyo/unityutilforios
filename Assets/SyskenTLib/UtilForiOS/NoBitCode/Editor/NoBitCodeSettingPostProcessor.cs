using SyskenTLib.UtilForiOS.CommonConfig.Editor;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEditor.Callbacks;
using UnityEngine;

#if UNITY_IOS
using UnityEditor.iOS.Xcode;
#endif


namespace SyskenTLib.UtilForiOS.NoBitcodeEditor
{
    public class NoBitCodeSettingPostProcessor 
    {

        
        [PostProcessBuild]
        public static void OnPostProcessBuild(BuildTarget buildTarget, string path)
        {

            if (buildTarget == BuildTarget.iOS)
            {
                SaveDataManager saveDataManager = new SaveDataManager();
                SyskenTLibUtilForiOSConfig config = saveDataManager.GetConfig();

                if (config.isAutoTurnOffBitCode){



                    string projectPath = path + "/Unity-iPhone.xcodeproj/project.pbxproj";
                    PBXProject pbxProject = new PBXProject();
                    pbxProject.ReadFromFile(projectPath);

                    //Main
                    string target = pbxProject.GetUnityMainTargetGuid();
                    pbxProject.SetBuildProperty(target, "ENABLE_BITCODE", "NO");

                    //テスト用
                    target = pbxProject.TargetGuidByName(PBXProject.GetUnityTestTargetName());
                    pbxProject.SetBuildProperty(target, "ENABLE_BITCODE", "NO");

                    //Unity Framework
                    target = pbxProject.GetUnityFrameworkTargetGuid();
                    pbxProject.SetBuildProperty(target, "ENABLE_BITCODE", "NO");

                    Debug.Log("BitCode Off");

                    pbxProject.WriteToFile(projectPath);
                }
            }
        }
    }
}