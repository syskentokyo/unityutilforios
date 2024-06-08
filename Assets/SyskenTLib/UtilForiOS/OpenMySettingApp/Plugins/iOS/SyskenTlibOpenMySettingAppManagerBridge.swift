import Foundation


 let  settingManager = SyskenTlibOpenMySettingAppManager()

@_cdecl("SyskenTlibOpenMySettingAppOpenMySettingApp")
public  func openMySettingApp(){
    settingManager.openMySettingApp()
}