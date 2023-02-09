using UnityEditor;

namespace SyskenTLib.UtilForiOS.CommonConfig.Editor
{
    public class RootWindow : UnityEditor.EditorWindow
    {
        /// <Summary>
        /// Rootの定義(らいぶらりごとにメニューに区切りをつけるためのダミー）
        /// </Summary>
        [MenuItem("SyskenTLib/UtilForiOS/",priority = 0)]
        private static void ShowWindow()
        {

        }

        private void OnGUI()
        {
            
        }
    }
}