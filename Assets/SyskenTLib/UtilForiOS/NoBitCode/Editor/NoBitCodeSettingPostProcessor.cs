
#if UNITY_EDITOR && UNITY_IOS
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;
    


using UnityEditor.iOS.Xcode;



namespace SyskenTLib.UtilForiOS.NoBitcodeEditor
{
    public class NoBitCodeSettingPostProcessor 
    {

        
        [PostProcessBuild(1)]
        public static void OnPostProcessBuild(BuildTarget buildTarget, string path)
        {

            if (buildTarget == BuildTarget.iOS)
            {
  
                SaveDataManager saveDataManager = new SaveDataManager();
                SyskenTLibUtilForiOSNoBitCodeConfig config = saveDataManager.GetConfig();

                if (config.isAutoTurnOffBitCode){



                    string projectPath = PBXProject.GetPBXProjectPath(path);
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

#endif