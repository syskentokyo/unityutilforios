import Foundation

class SyskenTlibOpenMySettingAppManager{


    public func openMySettingApp(){
        let url = URL(string: UIApplication.openSettingsURLString)
        
        if UIApplication.shared.canOpenURL(url!) {
            UIApplication.shared.open(url!, options: [:], completionHandler: nil)
        }
    }


}
