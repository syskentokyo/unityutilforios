
import Foundation

class SyskenTlibOSNativeUIManager{
    
    
    public  func showAlert(title:String,subTitle:String,okButtonName:String,cancelButtonName:String){
        
        let baseAppContoller = UIApplication.shared.delegate as? UnityAppController
        let rootViewController = baseAppContoller?.rootViewController
        
        let alertController = UIAlertController(title: title, message: subTitle, preferredStyle: .alert)
        
        //ボタン
        if(cancelButtonName != ""){
            alertController.addAction(UIAlertAction(title: cancelButtonName, style: .cancel, handler:  {_ in
                
                UnityFramework.getInstance().sendMessageToGO(withName: "SyskenTlibUtilForiOSOSNativeUIRecieveManager"
                                                             , functionName: "OnTouchedOSNativeAlertButton"
                                                             , message: "cancelButton")
                
            }))
        }
        
        
        if(okButtonName != ""){
            alertController.addAction(UIAlertAction(title: okButtonName, style: .destructive, handler: {_ in
                
                UnityFramework.getInstance().sendMessageToGO(withName: "SyskenTlibUtilForiOSOSNativeUIRecieveManager"
                                                             , functionName: "OnTouchedOSNativeAlertButton"
                                                             , message: "okbutton")
                
            }))
        }
        
        rootViewController?.present(alertController, animated: true,completion: {
            
            
        })
        
    }

    
    
}
