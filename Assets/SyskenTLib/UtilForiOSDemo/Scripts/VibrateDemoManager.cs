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
            }
        }
    }
}
