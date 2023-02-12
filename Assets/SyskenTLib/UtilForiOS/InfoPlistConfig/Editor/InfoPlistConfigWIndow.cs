using SyskenTLib.UtilForiOS.CommonConfig.Editor;
using UnityEditor;
using UnityEngine;

namespace SyskenTLib.UtilForiOS.InfoPlistConfig.Editor
{
    public class InfoPlistConfigWIndow : UnityEditor.EditorWindow
    {

        private Vector2 _currentScroveViewPosition = Vector2.zero;

        private bool _isFirstReadConfig = false;

        private bool isOverrideCameraUsage = false;
        private string cameraUsageDescription = "";

        
        private bool isOverrideLocationWhenAlwaysAndUseUsage = false;
        private string locationUsageWhenAlwaysAndUseDescription = "";        

        private bool isOverrideLocationWhenAlwaysUsage = false;
        private string locationUsageWhenAlwaysDescription = "";
        
        private bool isOverrideLocationWhenUseUsage = false;
        private string locationUsageWhenUseDescription = "";
        
        private bool isOverrideBluetoothAlwaysUsage = false;
        private string bluetoothAlwaysUsageDescription = "";
        
        private bool isOverrideLocalNetworkUsage = false;
        private string localNetworkUsageDescription = "";
        
        private bool isOverrideNFCScanUsage = false;
        private string nfcScanUsageDescription = "";
        
        private bool isOverridePhotoLibraryUsage = false;
        private string photoLibraryUsageDescription = "";
        
        private bool isOverridePhotoLibraryAddUsage = false;
        private string photoLibraryAddUsageDescription = "";
        

        [MenuItem("SyskenTLib/UtilForiOS/InfoPlistConfig", priority = 10)]
        private static void ShowWindow()
        {
            var window = GetWindow<InfoPlistConfigWIndow>();
            window.titleContent = new UnityEngine.GUIContent("InfoPlistConfig");
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
            
            //共通設定
            EditorGUIUtility.labelWidth = 300;   
            
            EditorGUILayout.Space(5);
            EditorGUILayout.LabelField("* Save To 0_config.json");
            
            EditorGUILayout.Space(15);
            
            
            EditorGUILayout.Space(5);
            isOverrideCameraUsage = EditorGUILayout.Toggle("OverrideCameraUsage", isOverrideCameraUsage);
            cameraUsageDescription = EditorGUILayout.TextField("CameraUsageDescription", cameraUsageDescription);

            EditorGUILayout.Space(5);
            isOverrideLocationWhenAlwaysAndUseUsage = EditorGUILayout.Toggle("OverrideLocationWhenAlwaysAndUseUsage", isOverrideLocationWhenAlwaysAndUseUsage);
            locationUsageWhenAlwaysAndUseDescription = EditorGUILayout.TextField("LocationUsageWhenAlwaysAndUseDescription", locationUsageWhenAlwaysAndUseDescription);
            
            
            EditorGUILayout.Space(5);
            isOverrideLocationWhenAlwaysUsage = EditorGUILayout.Toggle("OverrideLocationWhenAlwaysUsage", isOverrideLocationWhenAlwaysUsage);
            locationUsageWhenAlwaysDescription = EditorGUILayout.TextField("LocationUsageWhenAlwaysDescription", locationUsageWhenAlwaysDescription);


            EditorGUILayout.Space(5);
            isOverrideLocationWhenUseUsage = EditorGUILayout.Toggle("OverrideLocationWhenUseUsage", isOverrideLocationWhenUseUsage);
            locationUsageWhenUseDescription = EditorGUILayout.TextField("LocationUsageWhenUseDescription", locationUsageWhenUseDescription);



            EditorGUILayout.Space(5);
            isOverrideBluetoothAlwaysUsage = EditorGUILayout.Toggle("OverrideBluetoothAlwaysUsage", isOverrideBluetoothAlwaysUsage);
            bluetoothAlwaysUsageDescription = EditorGUILayout.TextField("BluetoothAlwaysUsageDescription", bluetoothAlwaysUsageDescription);
            
            EditorGUILayout.Space(5);
            isOverrideLocalNetworkUsage = EditorGUILayout.Toggle("OverrideLocalNetworkUsage", isOverrideLocalNetworkUsage);
            localNetworkUsageDescription = EditorGUILayout.TextField("LocalNetworkUsageDescription", localNetworkUsageDescription);
            
            EditorGUILayout.Space(5);
            isOverrideNFCScanUsage = EditorGUILayout.Toggle("OverrideNFCScanUsage", isOverrideNFCScanUsage);
            nfcScanUsageDescription = EditorGUILayout.TextField("NFCScanUsageDescription", nfcScanUsageDescription);
            
            EditorGUILayout.Space(5);
            isOverridePhotoLibraryUsage = EditorGUILayout.Toggle("OverridePhotoLibraryUsage", isOverridePhotoLibraryUsage);
            photoLibraryUsageDescription = EditorGUILayout.TextField("PhotoLibraryUsageDescription", photoLibraryUsageDescription);
            
            EditorGUILayout.Space(5);
            isOverridePhotoLibraryAddUsage = EditorGUILayout.Toggle("OverridePhotoLibraryAddUsage", isOverridePhotoLibraryAddUsage);
            photoLibraryAddUsageDescription = EditorGUILayout.TextField("PhotoLibraryAddUsageDescription", photoLibraryAddUsageDescription);


            

            EditorGUILayout.EndVertical();

            EditorGUILayout.EndScrollView();
        }

        private void ReadConfig()
        {
            SsaveDataManager ssaveDataManager = new SsaveDataManager();
            SaveDataJSON currentConfigJSON = ssaveDataManager.ReadProjectCommonConfig();


            isOverrideCameraUsage = currentConfigJSON.isOverrideCameraUsage;
            cameraUsageDescription = currentConfigJSON.cameraUsageDescription;

            isOverrideLocationWhenAlwaysAndUseUsage = currentConfigJSON.isOverrideLocationWhenAlwaysAndUseUsage;
            locationUsageWhenAlwaysAndUseDescription = currentConfigJSON.locationUsageWhenAlwaysAndUseDescription;
            
            isOverrideLocationWhenAlwaysUsage = currentConfigJSON.isOverrideLocationWhenAlwaysUsage;
            locationUsageWhenAlwaysDescription = currentConfigJSON.locationUsageWhenAlwaysDescription;
            
            isOverrideLocationWhenUseUsage = currentConfigJSON.isOverrideLocationWhenUseUsage;
            locationUsageWhenUseDescription = currentConfigJSON.locationUsageWhenUseDescription;
            
            isOverrideBluetoothAlwaysUsage = currentConfigJSON.isOverrideBluetoothAlwaysUsage;
            bluetoothAlwaysUsageDescription = currentConfigJSON.bluetoothAlwaysUsageDescription;
            
            isOverrideLocalNetworkUsage = currentConfigJSON.isOverrideLocalNetworkUsage;
            localNetworkUsageDescription = currentConfigJSON.localNetworkUsageDescription;
            
            isOverrideNFCScanUsage = currentConfigJSON.isOverrideNFCScanUsage;
            nfcScanUsageDescription = currentConfigJSON.nfcScanUsageDescription;
            
            isOverridePhotoLibraryUsage = currentConfigJSON.isOverridePhotoLibraryUsage;
            photoLibraryUsageDescription = currentConfigJSON.photoLibraryUsageDescription;
            
            isOverridePhotoLibraryAddUsage = currentConfigJSON.isOverridePhotoLibraryAddUsage;
            photoLibraryAddUsageDescription = currentConfigJSON.photoLibraryAddUsageDescription;

        }

        private void SaveConfig()
        {
            SsaveDataManager ssaveDataManager = new SsaveDataManager();
            SaveDataJSON currentConfigJSON = ssaveDataManager.ReadProjectCommonConfig();


            currentConfigJSON.isOverrideCameraUsage = isOverrideCameraUsage;
            currentConfigJSON.cameraUsageDescription = cameraUsageDescription;

            currentConfigJSON.isOverrideLocationWhenAlwaysAndUseUsage = isOverrideLocationWhenAlwaysAndUseUsage;
            currentConfigJSON.locationUsageWhenAlwaysAndUseDescription = locationUsageWhenAlwaysAndUseDescription;
            
            currentConfigJSON.isOverrideLocationWhenAlwaysUsage = isOverrideLocationWhenAlwaysUsage;
            currentConfigJSON.locationUsageWhenAlwaysDescription = locationUsageWhenAlwaysDescription;
            
            currentConfigJSON.isOverrideLocationWhenUseUsage = isOverrideLocationWhenUseUsage;
            currentConfigJSON.locationUsageWhenUseDescription = locationUsageWhenUseDescription;
            
            currentConfigJSON.isOverrideBluetoothAlwaysUsage = isOverrideBluetoothAlwaysUsage;
            currentConfigJSON.bluetoothAlwaysUsageDescription = bluetoothAlwaysUsageDescription;
            
            currentConfigJSON.isOverrideLocalNetworkUsage = isOverrideLocalNetworkUsage;
            currentConfigJSON.localNetworkUsageDescription = localNetworkUsageDescription;
            
            currentConfigJSON.isOverrideNFCScanUsage = isOverrideNFCScanUsage;
            currentConfigJSON.nfcScanUsageDescription = nfcScanUsageDescription;
            
            currentConfigJSON.isOverridePhotoLibraryUsage = isOverridePhotoLibraryUsage;
            currentConfigJSON.photoLibraryUsageDescription = photoLibraryUsageDescription;
            
            currentConfigJSON.isOverridePhotoLibraryAddUsage = isOverridePhotoLibraryAddUsage;
            currentConfigJSON.photoLibraryAddUsageDescription = photoLibraryAddUsageDescription;


            //保存
            ssaveDataManager.SaveProjectCommonConfig(currentConfigJSON);

        }

    }
}