using System.Collections;
using System.Collections.Generic;
using SyskenTLib.UtilForiOS.Vibrate;
using UnityEngine;

namespace SyskenTLib.UtilForiOS.Demo
{
    public class VibrateDemoManager : MonoBehaviour
    {
        private VibrateManager _vibrateManager = new VibrateManager();
        
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void OnTouchedDebugButton(int vibrateNum)
        {
            VibrateType vibrateType = VibrateType.UI_HEAVY;
            switch (vibrateNum)
            {
                case 0:
                    vibrateType = VibrateType.UI_HEAVY;
                    break;
                case 1:
                    vibrateType = VibrateType.UI_LIGHT;
                    break;
                case 2:
                    vibrateType = VibrateType.UI_MEDIUM;
                    break;
                case 3:
                    vibrateType = VibrateType.UI_RIDID;
                    break;
                case 4:
                    vibrateType = VibrateType.UI_SOFT;
                    break;
                case 5:
                    vibrateType = VibrateType.UI_SELECT;
                    break;
                case 6:
                    vibrateType = VibrateType.CUSTOM_HEARTBEAT_1;
                    break;
                case 7:
                    vibrateType = VibrateType.CUSTOM_HEARTBEAT_2;
                    break;
                case 8:
                    vibrateType = VibrateType.CUSTOM_HEARTBEAT_3;
                    break;
                case 9:
                    vibrateType = VibrateType.CUSTOM_HEARTBEAT_4;
                    break;
                case 10:
                    vibrateType = VibrateType.CUSTOM_HEARTBEAT_NORMAL_1;
                    break;
                case 11:
                    vibrateType = VibrateType.CUSTOM_HEARTBEAT_NORMAL_2;
                    break;
                case 12:
                    vibrateType = VibrateType.CUSTOM_HEARTBEAT_STRONG_1;
                    break;
                case 13:
                    vibrateType = VibrateType.CUSTOM_HEARTBEAT_STRONG_2;
                    break;
                case 14:
                    vibrateType = VibrateType.CUSTOM_GRADUALLY_1;
                    break;
                case 15:
                    vibrateType = VibrateType.CUSTOM_GRADUALLY_2;
                    break;
                case 16:
                    vibrateType = VibrateType.CUSTOM_KONKON_1;
                    break;
                case 17:
                    vibrateType = VibrateType.CUSTOM_KONKON_2;
                    break;
                case 18:
                    vibrateType = VibrateType.CUSTOM_ERROR_1;
                    break;
                case 19:
                    vibrateType = VibrateType.CUSTOM_ERROR_2;
                    break;
                case 20:
                    vibrateType = VibrateType.CUSTOM_ERROR_3;
                    break;
                case 21:
                    vibrateType = VibrateType.CUSTOM_ERROR_4;
                    break;
                case 22:
                    vibrateType = VibrateType.CUSTOM_ERROR_5;
                    break;
                case 23:
                    vibrateType = VibrateType.CUSTOM_WATER_1;
                    break;
                case 24:
                    vibrateType = VibrateType.CUSTOM_WATER_2;
                    break;
                case 25:
                    vibrateType = VibrateType.CUSTOM_WATER_3;
                    break;
                case 26:
                    vibrateType = VibrateType.CUSTOM_WATER_4;
                    break;
                case 27:
                    vibrateType = VibrateType.CUSTOM_WATER_5;
                    break;
                case 28:
                    vibrateType = VibrateType.CUSTOM_OTHER_1;
                    break;
                case 29:
                    vibrateType = VibrateType.CUSTOM_OTHER_2;
                    break;
                case 30:
                    vibrateType = VibrateType.CUSTOM_OTHER_3;
                    break;
                case 31:
                    vibrateType = VibrateType.CUSTOM_OTHER_4;
                    break;
                case 32:
                    vibrateType = VibrateType.CUSTOM_OTHER_4;
                    break;
                case 33:
                    vibrateType = VibrateType.CUSTOM_OTHER_4;
                    break;
                case 34:
                    vibrateType = VibrateType.CUSTOM_OTHER_4;
                    break;
                case 35:
                    vibrateType = VibrateType.CUSTOM_OTHER_4;
                    break;
                case 36:
                    vibrateType = VibrateType.CUSTOM_OTHER_4;
                    break;
                case 37:
                    vibrateType = VibrateType.CUSTOM_OTHER_4;
                    break;
                case 38:
                    vibrateType = VibrateType.CUSTOM_OTHER_4;
                    break;
                case 39:
                    vibrateType = VibrateType.CUSTOM_OTHER_4;
                    break;
            }
            
            
            Debug.Log("VibrateType: "+ vibrateType);
            
            _vibrateManager.Play(vibrateType);
        }
    }
}
