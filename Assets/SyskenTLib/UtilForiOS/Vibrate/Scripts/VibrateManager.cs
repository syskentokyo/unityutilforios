using System;
using UnityEngine;

namespace SyskenTLib.UtilForiOS.Vibrate
{
    public enum VibrateType : int
    {
        UI_HEAVY=0
        ,UI_LIGHT=1
        ,UI_MEDIUM=2
        ,UI_RIDID=3
        ,UI_SOFT=4
        ,UI_SELECT=5
        
        ,NOTICE_SUCCESS=100
        ,NOTICE_ERROR=101
        ,NOTICE_WARING=102
        
        
        ,CUSTOM_HEARTBEAT_1=300//0
        ,CUSTOM_HEARTBEAT_2=301//1
        ,CUSTOM_HEARTBEAT_3=302//8
        ,CUSTOM_HEARTBEAT_4=303//12
        ,CUSTOM_HEARTBEAT_NORMAL_1=304//13
        ,CUSTOM_HEARTBEAT_NORMAL_2=305//14
        ,CUSTOM_HEARTBEAT_STRONG_1=306//15
        ,CUSTOM_HEARTBEAT_STRONG_2=307//16
        ,CUSTOM_GRADUALLY_1=308//2
        ,CUSTOM_GRADUALLY_2=309//3
        ,CUSTOM_KONKON_1=310//4
        ,CUSTOM_KONKON_2=311//5
        ,CUSTOM_ERROR_1=312//6
        ,CUSTOM_ERROR_2=313//7
        ,CUSTOM_ERROR_3=314//9
        ,CUSTOM_ERROR_4=315//10
        ,CUSTOM_ERROR_5=316//11
        ,CUSTOM_WATER_1=317//17
        ,CUSTOM_WATER_2=318//18
        ,CUSTOM_WATER_3=319//19
        ,CUSTOM_WATER_4=320//20
        ,CUSTOM_WATER_5=321//21
        
        ,CUSTOM_OTHER_1=322
        ,CUSTOM_OTHER_2=323
        ,CUSTOM_OTHER_3=324
        ,CUSTOM_OTHER_4=325

        
    }
    
    
    public class VibrateManager
    {
        private OSNativeVibrateBridge _osNativeVibrateBridge = new OSNativeVibrateBridge();


        public void Play(VibrateType vibrateType)
        {
#if UNITY_EDITOR
            Debug.Log("UnityEditor:Play Vibrate: "+ vibrateType);
#elif UNITY_IOS
            PrepareVibrateInternal(vibrateType);
            PlayVibrateInternal(vibrateType);
#endif
        }

        public void PrepareVibrate(VibrateType vibrateType)
        {
#if UNITY_EDITOR
            Debug.Log("UnityEditor:PrepareVibrate Vibrate: "+ vibrateType);
#elif UNITY_IOS
            PrepareVibrateInternal(vibrateType);
#endif
        }

        public void PlayVibrate(VibrateType vibrateType)
        {
#if UNITY_EDITOR
            Debug.Log("UnityEditor:PlayVibrate Vibrate: "+ vibrateType);
#elif UNITY_IOS
            PlayVibrateInternal(vibrateType);
#endif
        }

        #region 内部

        private void PrepareVibrateInternal(VibrateType vibrateType)
        {
            switch (vibrateType)
            {
                case VibrateType.UI_HEAVY:
                    _osNativeVibrateBridge.PrepareVibrate(0, 0);
                    break;
                case VibrateType.UI_LIGHT:
                    _osNativeVibrateBridge.PrepareVibrate(0, 1);
                    break;
                case VibrateType.UI_MEDIUM:
                    _osNativeVibrateBridge.PrepareVibrate(0, 2);
                    break;
                case VibrateType.UI_RIDID:
                    _osNativeVibrateBridge.PrepareVibrate(0, 3);
                    break;
                case VibrateType.UI_SOFT:
                    _osNativeVibrateBridge.PrepareVibrate(0, 4);
                    break;
                case VibrateType.UI_SELECT:
                    _osNativeVibrateBridge.PrepareVibrate(1, 0);
                    break;
                case VibrateType.NOTICE_SUCCESS:
                    _osNativeVibrateBridge.PrepareVibrate(2, 0);
                    break;
                case VibrateType.NOTICE_ERROR:
                    _osNativeVibrateBridge.PrepareVibrate(2, 1);
                    break;
                case VibrateType.NOTICE_WARING:
                    _osNativeVibrateBridge.PrepareVibrate(2, 2);
                    break;
               
                default:
                    break;
            }
        }

        private void PlayVibrateInternal(VibrateType vibrateType)
        {
            switch (vibrateType)
            {
                case VibrateType.UI_HEAVY:
                    _osNativeVibrateBridge.PlayVibrate(0, 0,100);
                    break;
                case VibrateType.UI_LIGHT:
                    _osNativeVibrateBridge.PlayVibrate(0, 1,100);
                    break;
                case VibrateType.UI_MEDIUM:
                    _osNativeVibrateBridge.PlayVibrate(0, 2,100);
                    break;
                case VibrateType.UI_RIDID:
                    _osNativeVibrateBridge.PlayVibrate(0, 3,100);
                    break;
                case VibrateType.UI_SOFT:
                    _osNativeVibrateBridge.PlayVibrate(0, 4,100);
                    break;
                case VibrateType.UI_SELECT:
                    _osNativeVibrateBridge.PlayVibrate(1, 0,100);
                    break;
                case VibrateType.NOTICE_SUCCESS:
                    _osNativeVibrateBridge.PlayVibrate(2, 0,100);
                    break;
                case VibrateType.NOTICE_ERROR:
                    _osNativeVibrateBridge.PlayVibrate(2, 1,100);
                    break;
                case VibrateType.NOTICE_WARING:
                    _osNativeVibrateBridge.PlayVibrate(2, 2,100);
                    break;
                case VibrateType.CUSTOM_HEARTBEAT_1:
                    _osNativeVibrateBridge.PlayVibrate(3, 0,100);
                    break;
                case VibrateType.CUSTOM_HEARTBEAT_2:
                    _osNativeVibrateBridge.PlayVibrate(3,1,100);
                    break;
                case VibrateType.CUSTOM_HEARTBEAT_3:
                    _osNativeVibrateBridge.PlayVibrate(3,8,100);
                    break;
                case VibrateType.CUSTOM_HEARTBEAT_4:
                    _osNativeVibrateBridge.PlayVibrate(3,12,100);
                    break;
                case VibrateType.CUSTOM_HEARTBEAT_NORMAL_1:
                    _osNativeVibrateBridge.PlayVibrate(3,13,100);
                    break;
                case VibrateType.CUSTOM_HEARTBEAT_NORMAL_2:
                    _osNativeVibrateBridge.PlayVibrate(3,14,100);
                    break;
                case VibrateType.CUSTOM_HEARTBEAT_STRONG_1:
                    _osNativeVibrateBridge.PlayVibrate(3,15,100);
                    break;
                case VibrateType.CUSTOM_HEARTBEAT_STRONG_2:
                    _osNativeVibrateBridge.PlayVibrate(3,16,100);
                    break;
                case VibrateType.CUSTOM_GRADUALLY_1:
                    _osNativeVibrateBridge.PlayVibrate(3,2,100);
                    break;
                case VibrateType.CUSTOM_GRADUALLY_2:
                    _osNativeVibrateBridge.PlayVibrate(3,3,100);
                    break;
                case VibrateType.CUSTOM_KONKON_1:
                    _osNativeVibrateBridge.PlayVibrate(3,4,100);
                    break;
                case VibrateType.CUSTOM_KONKON_2:
                    _osNativeVibrateBridge.PlayVibrate(3,5,100);
                    break;
                case VibrateType.CUSTOM_ERROR_1:
                    _osNativeVibrateBridge.PlayVibrate(3,6,100);
                    break;
                case VibrateType.CUSTOM_ERROR_2:
                    _osNativeVibrateBridge.PlayVibrate(3,7,100);
                    break;
                case VibrateType.CUSTOM_ERROR_3:
                    _osNativeVibrateBridge.PlayVibrate(3,9,100);
                    break;
                case VibrateType.CUSTOM_ERROR_4:
                    _osNativeVibrateBridge.PlayVibrate(3,10,100);
                    break;
                case VibrateType.CUSTOM_ERROR_5:
                    _osNativeVibrateBridge.PlayVibrate(3,11,100);
                    break;
                case VibrateType.CUSTOM_WATER_1:
                    _osNativeVibrateBridge.PlayVibrate(3,17,100);
                    break;
                case VibrateType.CUSTOM_WATER_2:
                    _osNativeVibrateBridge.PlayVibrate(3,18,100);
                    break;
                case VibrateType.CUSTOM_WATER_3:
                    _osNativeVibrateBridge.PlayVibrate(3,19,100);
                    break;
                case VibrateType.CUSTOM_WATER_4:
                    _osNativeVibrateBridge.PlayVibrate(3,20,100);
                    break;
                case VibrateType.CUSTOM_WATER_5:
                    _osNativeVibrateBridge.PlayVibrate(3,21,100);
                    break;
                case VibrateType.CUSTOM_OTHER_1:
                    _osNativeVibrateBridge.PlayVibrate(3,22,100);
                    break;
                case VibrateType.CUSTOM_OTHER_2:
                    _osNativeVibrateBridge.PlayVibrate(3,23,100);
                    break;
                case VibrateType.CUSTOM_OTHER_3:
                    _osNativeVibrateBridge.PlayVibrate(3,24,100);
                    break;
                case VibrateType.CUSTOM_OTHER_4:
                    _osNativeVibrateBridge.PlayVibrate(3,25,100);
                    break;
                default:
                    break;
            }
        }

        #endregion
        
        
    }
}