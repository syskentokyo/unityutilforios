using System;
using JetBrains.Annotations;
using UnityEngine;

namespace SyskenTLib.UtilForiOS.OSNativeUI
{
    public class SyskenTlibUtilForiOSOSNativeUIRecieveManager : MonoBehaviour
    {
        
        /// <summary>
        /// メッセージ受診時はここに通知されます
        /// </summary>
        public Action<string> _onRecievedAction;
        
        /// <summary>
        /// OSネイティブのアラートのボタン押したときの通知先
        /// </summary>
        /// <param name="message"></param>
        [UsedImplicitly]
        private void OnTouchedOSNativeAlertButton(string message)
        {
            _onRecievedAction?.Invoke(message);
        }
    }
}