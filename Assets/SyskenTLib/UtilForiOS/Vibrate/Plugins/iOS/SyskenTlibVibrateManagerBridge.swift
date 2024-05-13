import Foundation


 let  vibaraManager = SyskenTlibVibrateManager()

@_cdecl("SyskenTlibVibratePrepareVibrate")
public  func prepareVibrate(groupID:Int32,typeID:Int32){
    vibaraManager.prepareVibrate(groupID: Int(groupID), typeID:Int(typeID))
}



@_cdecl("SyskenTlibVibratePlayVibrate")
public  func startVibrate(groupID:Int32,typeID:Int32,strength:Int32){
                                 
    vibaraManager.startVibrate(groupID: Int(groupID), typeID:Int(typeID), strength: Int(strength))
}
