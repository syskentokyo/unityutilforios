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
            switch (vibrateNum)
            {
                case 0:
                    _vibrateManager.PrepareVibrate(0,0);
                    _vibrateManager.PlayVibrate(0,0,100);
                    break;
                case 1:
                    _vibrateManager.PrepareVibrate(0,1);
                    _vibrateManager.PlayVibrate(0,1,100);
                    break;
                case 2:
                    _vibrateManager.PrepareVibrate(0,2);
                    _vibrateManager.PlayVibrate(0,2,100);
                    break;
                case 3:
                    _vibrateManager.PrepareVibrate(0,3);
                    _vibrateManager.PlayVibrate(0,3,100);
                    break;
                case 4:
                    _vibrateManager.PrepareVibrate(0,4);
                    _vibrateManager.PlayVibrate(0,4,100);
                    break;
                case 5:
                    _vibrateManager.PrepareVibrate(1,0);
                    _vibrateManager.PlayVibrate(1,0,100);
                    break;
                case 6:
                    _vibrateManager.PrepareVibrate(2,0);
                    _vibrateManager.PlayVibrate(2,0,100);
                    break;
                case 7:
                    _vibrateManager.PrepareVibrate(2,0);
                    _vibrateManager.PlayVibrate(2,1,100);
                    break;
                case 8:
                    _vibrateManager.PrepareVibrate(2,0);
                    _vibrateManager.PlayVibrate(2,2,100);
                    break;
                case 9:
                    _vibrateManager.PlayVibrate(3,0,100);
                    break;
                case 10:
                    _vibrateManager.PlayVibrate(3,1,100);
                    break;
                case 11:
                    _vibrateManager.PlayVibrate(3,2,100);
                    break;
                case 12:
                    _vibrateManager.PlayVibrate(3,3,100);
                    break;
                case 13:
                    _vibrateManager.PlayVibrate(3,4,100);
                    break;
                case 14:
                    _vibrateManager.PlayVibrate(3,5,100);
                    break;
                case 15:
                    _vibrateManager.PlayVibrate(3,6,100);
                    break;
                case 16:
                    _vibrateManager.PlayVibrate(3,7,100);
                    break;
                case 17:
                    _vibrateManager.PlayVibrate(3,8,100);
                    break;
                case 18:
                    _vibrateManager.PlayVibrate(3,9,100);
                    break;
                case 19:
                    _vibrateManager.PlayVibrate(3,10,100);
                    break;
                case 20:
                    _vibrateManager.PlayVibrate(3,11,100);
                    break;
                case 21:
                    _vibrateManager.PlayVibrate(3,12,100);
                    break;
                case 22:
                    _vibrateManager.PlayVibrate(3,13,100);
                    break;
                case 23:
                    _vibrateManager.PlayVibrate(3,14,100);
                    break;
                case 24:
                    _vibrateManager.PlayVibrate(3,15,100);
                    break;
                case 25:
                    _vibrateManager.PlayVibrate(3,16,100);
                    break;
                case 26:
                    _vibrateManager.PlayVibrate(3,17,100);
                    break;
                case 27:
                    _vibrateManager.PlayVibrate(3,18,100);
                    break;
                case 28:
                    _vibrateManager.PlayVibrate(3,19,100);
                    break;
                case 29:
                    _vibrateManager.PlayVibrate(3,20,100);
                    break;
                case 30:
                    _vibrateManager.PlayVibrate(3,21,100);
                    break;
                case 31:
                    _vibrateManager.PlayVibrate(3,22,100);
                    break;
                case 32:
                    _vibrateManager.PlayVibrate(3,23,100);
                    break;
                case 33:
                    _vibrateManager.PlayVibrate(3,24,100);
                    break;
                case 34:
                    _vibrateManager.PlayVibrate(3,25,100);
                    break;
                case 35:
                    _vibrateManager.PlayVibrate(3,26,100);
                    break;
                case 36:
                    _vibrateManager.PlayVibrate(3,27,100);
                    break;
                case 37:
                    _vibrateManager.PlayVibrate(3,28,100);
                    break;
                case 38:
                    _vibrateManager.PlayVibrate(3,29,100);
                    break;
                case 39:
                    _vibrateManager.PlayVibrate(3,30,100);
                    break;

            }
        }
    }
}
