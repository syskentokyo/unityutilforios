import Foundation

@_cdecl("SyskenTlibCustomKeychainBridgeIsExistData")
public  func isExistData(serviceName:UnsafePointer<CChar>,keyName:UnsafePointer<CChar>)-> Bool{
    
    let serviceNameTxt = String(cString: serviceName)
    let keyNameTxt = String(cString: keyName)
    
    
    let customKeychain = SyskenTlibCustomKeychain()
    
    let isExist = customKeychain.isExistData(serviceName: serviceNameTxt,keyName: keyNameTxt)
    
    return isExist;
    
}

@_cdecl("SyskenTlibCustomKeychainBridgeDelete")
public  func deleteData(serviceName:UnsafePointer<CChar>,keyName:UnsafePointer<CChar>){
    
    let serviceNameTxt = String(cString: serviceName)
    let keyNameTxt = String(cString: keyName)
    
    
    let customKeychain = SyskenTlibCustomKeychain()
    
      customKeychain.deleteData(serviceName: serviceNameTxt,keyName: keyNameTxt)    
}

@_cdecl("SyskenTlibCustomKeychainBridgeSave")
public  func save(serviceName:UnsafePointer<CChar>
                  ,keyName:UnsafePointer<CChar>,saveValue:UnsafePointer<CChar>){
    let serviceNameTxt = String(cString: serviceName)
    let keyNameTxt = String(cString: keyName)
    let saveValueTxt = String(cString: saveValue)
    
    let customKeychain = SyskenTlibCustomKeychain()
    customKeychain.save(serviceName: serviceNameTxt,keyName: keyNameTxt,saveValue: saveValueTxt)
}

 
 @_cdecl("SyskenTlibCustomKeychainBridgeRead")
 public func read(serviceName:UnsafePointer<CChar>
                  ,keyName:UnsafePointer<CChar>) -> UnsafeMutablePointer<CChar>{
     
     let serviceNameTxt = String(cString: serviceName)
     let keyNameTxt = String(cString: keyName)
     
     let customKeychain = SyskenTlibCustomKeychain()
     let resultTxt = customKeychain.read(serviceName: serviceNameTxt,keyName: keyNameTxt)
     
     
     return strdup(resultTxt)
 
 }
       
