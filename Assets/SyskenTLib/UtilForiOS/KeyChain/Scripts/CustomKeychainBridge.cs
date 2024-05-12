using System;
using System.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

namespace SyskenTLib.UtilForiOS.KeyChain
{

    public class CustomKeychainBridge
    {
#if UNITY_IOS
        [DllImport("__Internal", EntryPoint = "SyskenTlibCustomKeychainBridgeIsExistData")]
        private static extern bool SyskenTlibCustomKeychainBridgeIsExistData(String serviceName,String keyName);
        
        [DllImport("__Internal", EntryPoint = "SyskenTlibCustomKeychainBridgeDelete")]
        private static extern bool SyskenTlibCustomKeychainBridgeDelete(String serviceName,String keyName);
        
        [DllImport("__Internal", EntryPoint = "SyskenTlibCustomKeychainBridgeSave")]
        private static extern void SyskenTlibCustomKeychainBridgeSave(String serviceName,String keyName,String saveValue);
        
        [DllImport("__Internal", EntryPoint = "SyskenTlibCustomKeychainBridgeRead")]
        private static extern string SyskenTlibCustomKeychainBridgeRead(String serviceName,String keyName);

#endif

        public bool IsExistData(String serviceName, String keyName)
        {
#if UNITY_IOS
            bool isExist = SyskenTlibCustomKeychainBridgeIsExistData(serviceName, keyName);
            return isExist;
#endif
            return false;
        }

        public void Delete(String serviceName, String keyName)
        {
            #if UNITY_IOS
            SyskenTlibCustomKeychainBridgeDelete(serviceName, keyName);
            #endif
        }
        
        
        public void Save(String serviceName, String keyName, String saveValue)
        {
#if UNITY_IOS
            SyskenTlibCustomKeychainBridgeSave(serviceName, keyName, saveValue);
#endif
        }

        public string Read(String serviceName, String keyName)
        {
#if UNITY_IOS
            return SyskenTlibCustomKeychainBridgeRead(serviceName, keyName);
#endif
            return "";
        }


    }
}