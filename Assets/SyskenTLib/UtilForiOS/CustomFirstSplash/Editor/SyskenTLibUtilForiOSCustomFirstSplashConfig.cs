using UnityEngine;

namespace SyskenTLib.UtilForiOS.CustomFirstSplash.Editor
{

    
    public class SyskenTLibUtilForiOSCustomFirstSplashConfig : ScriptableObject
    {
        public bool isEnableOverwriteSplash = false;


        [Header("Source File")]
        [SerializeField]
        public TextAsset splashLogImage = null;
            
        [SerializeField]
        public TextAsset iPhoneBackgroundImage= null;
        
        [SerializeField]
        public TextAsset iPadBackgroundImage= null;
        
        [SerializeField] public TextAsset splashStoryboardIPhone = null;
        [SerializeField] public TextAsset splashStoryboardIpad = null;
        
    }
}