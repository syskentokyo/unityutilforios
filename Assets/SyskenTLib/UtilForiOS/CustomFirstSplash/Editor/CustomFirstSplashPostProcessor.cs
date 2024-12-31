
#if UNITY_EDITOR && UNITY_IOS
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;
    


using UnityEditor.iOS.Xcode;


namespace SyskenTLib.UtilForiOS.CustomFirstSplash.Editor
{
    public class CustomFirstSplashPostProcessor
    {
     
        
        [PostProcessBuild(1)]
        public static void OnPostProcessBuild(BuildTarget buildTarget, string path)
        {

            if (buildTarget == BuildTarget.iOS)
            {
  
                SaveDataManager saveDataManager = new SaveDataManager();
                SyskenTLibUtilForiOSCustomFirstSplashConfig config = saveDataManager.GetConfig();

                if (config.isEnableOverwriteSplash == true){



                    string projectPath = PBXProject.GetPBXProjectPath(path);
                    string projectDirPath =　 System.IO.Directory.GetParent(System.IO.Path.GetDirectoryName (projectPath)).FullName;
                    Debug.Log("ProjectPath "+projectDirPath);
                    
                    
                    //
                    // SplashのiPhone用背景書き込み
                    //
                    string splashSceneBackgroundForIphonePath = System.IO.Path.Combine(projectDirPath, "LaunchScreen-iPhonePortrait.png");
                    byte[] splashSceneBackgroundForIphoneBytes = config.iPhoneBackgroundImage.bytes;;
                    System.IO.File.WriteAllBytes(splashSceneBackgroundForIphonePath, splashSceneBackgroundForIphoneBytes);
                    
                    //
                    // SplashのiPad用背景書き込み
                    //
                    string splashSceneBackgroundForIPadPath = System.IO.Path.Combine(projectDirPath, "LaunchScreen-iPad.png");
                    byte[] splashSceneBackgroundForIPadBytes = config.iPadBackgroundImage.bytes;;
                    System.IO.File.WriteAllBytes(splashSceneBackgroundForIPadPath, splashSceneBackgroundForIPadBytes);
                    
                                        
                    //
                    // SplashのiPone用Storyboard書き込み
                    //
                    string splashSceneStoryboardForIPhonePath = System.IO.Path.Combine(projectDirPath, "LaunchScreen-iPhone.storyboard");
                    string splashSceneStoryboardForIPhoneText = config.splashStoryboardIPhone.text;;
                    System.IO.File.WriteAllText(splashSceneStoryboardForIPhonePath, splashSceneStoryboardForIPhoneText);

                    //
                    // SplashのiPad用Storyboard書き込み
                    //
                    string splashSceneStoryboardForIPadPath = System.IO.Path.Combine(projectDirPath, "LaunchScreen-iPad.storyboard");
                    string splashSceneStoryboardForIPadText = config.splashStoryboardIpad.text;;
                    System.IO.File.WriteAllText(splashSceneStoryboardForIPadPath, splashSceneStoryboardForIPadText);

                    
                    //
                    //ロゴ書き込み
                    //
                    string logoPath = System.IO.Path.Combine(projectDirPath, "appmainlogo.png");
                    byte[] logoBytes = config.splashLogImage.bytes;;
                    System.IO.File.WriteAllBytes(logoPath, logoBytes);
                    
                    //ロゴファイルのパスを追加する
                    PBXProject pbxProject = new PBXProject();
                    pbxProject.ReadFromFile(projectPath);

                    pbxProject.AddFile(logoPath,"/appmainlogo.png");
                    
                    pbxProject.WriteToFile(projectPath);
     

                }

            }
        }
    }
}

#endif