import Foundation
import UIKit;


@objc public class LightManagerBridge : NSObject {
    
    @objc public static func TurnOn() {
        let lightManager = LightManager()
        lightManager.turnLight(isOn:true)
    }
    
    
    @objc public static func TurnOff() {
        let lightManager = LightManager()
        lightManager.turnLight(isOn:false)
    }
}
