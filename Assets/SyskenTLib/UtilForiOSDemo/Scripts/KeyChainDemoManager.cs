using System.Collections;
using System.Collections.Generic;
using SyskenTLib.UtilForiOS.KeyChain;
using UnityEngine;

namespace SyskenTLib.UtilForiOS.Demo
{
    public class KeyChainDemoManager : MonoBehaviour
    {

        public void OnTouchedCreate()
        {
            CustomKeychainBridge customKeychainBridge = new CustomKeychainBridge();
            
            Debug.Log("is Exist = "+customKeychainBridge.IsExistData("aa", "bb"));
            
            customKeychainBridge.Save("aa","bb","cc");

            string saveData = customKeychainBridge.Read("aa", "bb");
            Debug.Log(saveData);
            
            Debug.Log("is Exist = "+customKeychainBridge.IsExistData("aa", "bb"));
        }
        

        public void OnTouchedDelete()
        {
            
            
            CustomKeychainBridge customKeychainBridge = new CustomKeychainBridge();
            
            Debug.Log("is Exist = "+customKeychainBridge.IsExistData("aa", "bb"));
            
            string saveData = customKeychainBridge.Read("aa", "bb");
            Debug.Log(saveData);
            
            customKeychainBridge.Delete("aa", "bb");
            Debug.Log("is Exist = "+customKeychainBridge.IsExistData("aa", "bb"));
        }
    }
}
