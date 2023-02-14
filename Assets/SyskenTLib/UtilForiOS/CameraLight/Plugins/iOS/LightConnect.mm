 #import <UnityFramework/UnityFramework-Swift.h>

 #ifdef __cplusplus
 extern "C" {
 #endif
    void UtilForiOS_TurnDeviceLightOn() {
        [LightManagerBridge TurnOn];
    }
     void UtilForiOS_TurnDeviceLightOff() {
         [LightManagerBridge TurnOff];
     }
     
 #ifdef __cplusplus
 }
 #endif
