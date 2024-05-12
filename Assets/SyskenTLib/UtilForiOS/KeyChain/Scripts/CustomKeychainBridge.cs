using System;
using System.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

namespace SyskenTLib.UtilForiOS.KeyChain
{

    public class CustomKeychainBridge
    {
        [DllImport("__Internal", EntryPoint = "SyskenTlibCustomKeychainBridgeIsExistData")]
        private static extern bool SyskenTlibCustomKeychainBridgeIsExistData(String serviceName,String keyName);
        
        [DllImport("__Internal", EntryPoint = "SyskenTlibCustomKeychainBridgeDelete")]
        private static extern bool SyskenTlibCustomKeychainBridgeDelete(String serviceName,String keyName);
        
        [DllImport("__Internal", EntryPoint = "SyskenTlibCustomKeychainBridgeSave")]
        private static extern void SyskenTlibCustomKeychainBridgeSave(String serviceName,String keyName,String saveValue);
        
        [DllImport("__Internal", EntryPoint = "SyskenTlibCustomKeychainBridgeRead")]
        private static extern string SyskenTlibCustomKeychainBridgeRead(String serviceName,String keyName);



        public bool IsExistData(String serviceName, String keyName)
        {
            bool isExist = SyskenTlibCustomKeychainBridgeIsExistData(serviceName, keyName);
            return isExist;
        }

        public void Delete(String serviceName, String keyName)
        {
            SyskenTlibCustomKeychainBridgeDelete(serviceName, keyName);
        }
        
        
        public void Save(String serviceName, String keyName, String saveValue)
        {
            SyskenTlibCustomKeychainBridgeSave(serviceName, keyName, saveValue);
        }

        public string Read(String serviceName, String keyName)
        {
            return SyskenTlibCustomKeychainBridgeRead(serviceName, keyName);
        }


    }
}