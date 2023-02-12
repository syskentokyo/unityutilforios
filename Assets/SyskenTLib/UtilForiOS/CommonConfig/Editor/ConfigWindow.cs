using UnityEditor;
using UnityEngine;

namespace SyskenTLib.UtilForiOS.CommonConfig.Editor
{
    public class ConfigWindow : EditorWindow
    {

        private Vector2 _currentScroveViewPosition = Vector2.zero;

        private bool _isFirstReadConfig = false;

        private bool _currentIsAutoTurnAffBitCode = false;
        
        [MenuItem("SyskenTLib/UtilForiOS/Config",priority = 0)]
        private static void ShowWindow()
        {
            
            //
            var window = GetWindow<ConfigWindow>();
            window.titleContent = new GUIContent("UtilForiOS - Config");
            window.Show();
        }

        private void OnGUI()
        {

            if (_isFirstReadConfig == false)
            {
                //設定読み込み
                ReadConfig();

                _isFirstReadConfig = true;
            }
            
            
            //固定
            EditorGUILayout.BeginHorizontal("Box");
            
            EditorGUILayout.Space(10);
            
            if (GUILayout.Button("Read",GUILayout.Width(100)))
            {
            
                //設定読み込み
                ReadConfig();
            }

            Color currentColor = GUI.color;
            GUI.color = Color.red;
            if (GUILayout.Button("Save",GUILayout.Width(100)))
            {
                SaveConfig();
            }

            GUI.color = currentColor;
            
                        
            EditorGUILayout.EndHorizontal();
            
            
            
            //スクロール
            _currentScroveViewPosition = EditorGUILayout.BeginScrollView(_currentScroveViewPosition);
            
            
            EditorGUILayout.BeginVertical("Box");
            
            EditorGUILayout.Space(5);
            EditorGUILayout.LabelField("*1 Save To 0_config.json");
            EditorGUILayout.LabelField("*2 See infoplistconfig for info.plist edits");
            
            EditorGUILayout.Space(15);


            _currentIsAutoTurnAffBitCode = EditorGUILayout.Toggle ("AutoTurnOffBitCode", _currentIsAutoTurnAffBitCode);
            
            
            
            
            
            EditorGUILayout.EndVertical();
            
            EditorGUILayout.EndScrollView();
        }

        private  void ReadConfig()
        {
            SsaveDataManager ssaveDataManager = new SsaveDataManager();
            SaveDataJSON currentConfigJSON = ssaveDataManager.ReadProjectCommonConfig();


            _currentIsAutoTurnAffBitCode = currentConfigJSON.isAutoTurnAffBitCode;

        }
        
        private  void SaveConfig()
        {
            SsaveDataManager ssaveDataManager = new SsaveDataManager();
            SaveDataJSON currentConfigJSON = ssaveDataManager.ReadProjectCommonConfig();


            currentConfigJSON.isAutoTurnAffBitCode = _currentIsAutoTurnAffBitCode;
            
            
            //保存
            ssaveDataManager.SaveProjectCommonConfig(currentConfigJSON);

        }
    }
}