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
                SsaveDataManager ssaveDataManager = new SsaveDataManager();
                SaveDataJSON currentConfigJSON = ssaveDataManager.ReadProjectCommonConfig();

                if (currentConfigJSON.isAutoTurnAffBitCode){



                    string projectPath = path + "/Unity-iPhone.xcodeproj/project.pbxproj";
                    PBXProject pbxProject = new PBXProject();
                    pbxProject.ReadFromFile(projectPath);

                    //Main
                    string target = pbxProject.GetUnityMainTargetGuid();
                    pbxProject.SetBuildProperty(target, "ENABLE_BITCODE", "NO");

                    //ใในใ็จ
                    target = pbxProject.TargetGuidByName(PBXProject.GetUnityTestTargetName());
                    pbxProject.SetBuildProperty(target, "ENABLE_BITCODE", "NO");

                    //Unity Framework
                    target = pbxProject.GetUnityFrameworkTargetGuid();
                    pbxProject.SetBuildProperty(target, "ENABLE_BITCODE", "NO");


                    pbxProject.WriteToFile(projectPath);
                }
            }
        }
    }
}