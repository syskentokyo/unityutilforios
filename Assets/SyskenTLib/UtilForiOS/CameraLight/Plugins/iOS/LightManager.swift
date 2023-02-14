import Foundation
import AVFoundation

class LightManager{
    
    
    
    func turnLight(isOn: Bool){
        
        
        let  avCaptureDevice = AVCaptureDevice.default(for: AVMediaType.video)!
        
        
        if avCaptureDevice.hasTorch{
            //ライトを持つデバイスの場合
            do{
                try avCaptureDevice.lockForConfiguration()
                
                if(isOn==true){
                    
                    try avCaptureDevice.setTorchModeOn(level: 1.0)
                    
                }else{
                    avCaptureDevice.torchMode = .off
                }
                
                
                
                avCaptureDevice.unlockForConfiguration()
                
            }catch let error{
                print("ライト関係でエラー")
                print(error)
            }
            
        }else{
            
        }
        
    }
}
