using JetBrains.Annotations;
using UnityEngine;

namespace SyskenTLib.UtilForiOS.OSNativeUI
{
    public class SyskenTlibUtilForiOSOSNativeUIRecieveManager : MonoBehaviour
    {
        /// <summary>
        /// OSネイティブのアラートのボタン押したときの通知先
        /// </summary>
        /// <param name="message"></param>
        [UsedImplicitly]
        private void OnTouchedOSNativeAlertButton(string message)
        {
            // Debug.Log(message);
        }
    }
}