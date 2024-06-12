import Foundation

@_cdecl("SyskenTlibOSNativeUIShowAlert")
public  func showAlert(title:UnsafePointer<CChar>,subTitle:UnsafePointer<CChar>,okButtonName:UnsafePointer<CChar>,cancelButtonName:UnsafePointer<CChar>){
    
    let titleTxt = String(cString: title)
    let subTitleTxt = String(cString: subTitle)
    let okButtonNameTxt = String(cString: okButtonName)
    let cancelButtonNameTxt = String(cString: cancelButtonName)
            
    
    
    let osNativeUIManager = SyskenTlibOSNativeUIManager()
    
    osNativeUIManager.showAlert(title: titleTxt,subTitle: subTitleTxt,okButtonName:okButtonNameTxt,cancelButtonName:cancelButtonNameTxt)

    
}