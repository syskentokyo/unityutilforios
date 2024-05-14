import Foundation
import CoreHaptics
class SyskenTlibVibrateManager{
    
    var currentUIFeedbackGenerator:UIFeedbackGenerator?
    var lastPlayGroupID:Int = -99
    
    var currenthapticEngine: CHHapticEngine?
    
    public func prepareVibrate(groupID:Int,typeID:Int){
        switch groupID {
        case 0:
            prepareUIImpactFeedbackGeneratorVibrate(typeID:typeID)
            break
        case 1:
            prepareUISelectionFeedbackGeneratorVibrate()
            break
        case 2:
            prepareUINotificationFeedbackGeneratorVibrate()
            break
        default:
            break
        }
        
        lastPlayGroupID = groupID

    }
    
    public  func startVibrate(groupID:Int,typeID:Int,strength:Int){
        switch groupID {
        case 0:
            if(lastPlayGroupID != groupID){
                prepareUIImpactFeedbackGeneratorVibrate(typeID: typeID)
            }
            playUIImpactFeedbackGeneratorVibrate(strength: strength)
            break
        case 1:
            if(lastPlayGroupID != groupID){
                prepareUISelectionFeedbackGeneratorVibrate()
            }
            playUISelectionFeedbackGeneratorVibrate()
            break
        case 2:
            if(lastPlayGroupID != groupID){
                prepareUINotificationFeedbackGeneratorVibrate()
            }
            playUINotificationFeedbackGeneratorVibrate(typeID: typeID);
            break
         case 3:
             playVibrate(typeID: typeID);
    break;
        default:
            break
        }
        
        lastPlayGroupID = groupID
    }
  
    
    //
    //
    //
    
    private func prepareUIImpactFeedbackGeneratorVibrate(typeID:Int){

        currentUIFeedbackGenerator = nil
        currentUIFeedbackGenerator = UIImpactFeedbackGenerator()
        switch typeID {
        case 0:
            currentUIFeedbackGenerator = UIImpactFeedbackGenerator(style:.heavy)
            break
        case 1:
            currentUIFeedbackGenerator = UIImpactFeedbackGenerator(style:.light)
            break
        case 2:
            currentUIFeedbackGenerator = UIImpactFeedbackGenerator(style:.medium)
            break
        case 3:
            currentUIFeedbackGenerator = UIImpactFeedbackGenerator(style:.rigid)
            break
        case 4:
            currentUIFeedbackGenerator = UIImpactFeedbackGenerator(style:.soft)
            break
        default:
            break
        }
        currentUIFeedbackGenerator?.prepare()

    }
    
    private func prepareUISelectionFeedbackGeneratorVibrate(){

        currentUIFeedbackGenerator = nil
        currentUIFeedbackGenerator = UISelectionFeedbackGenerator()
        currentUIFeedbackGenerator?.prepare()

    }
    
    private func prepareUINotificationFeedbackGeneratorVibrate(){

        currentUIFeedbackGenerator = nil
        currentUIFeedbackGenerator = UINotificationFeedbackGenerator()
        currentUIFeedbackGenerator?.prepare()

    }
    
    //
    //
    //
    private func playUIImpactFeedbackGeneratorVibrate(strength:Int){
        let strengthValue = (Double)(strength%101) * 0.01
        (currentUIFeedbackGenerator as! UIImpactFeedbackGenerator).impactOccurred(intensity: strengthValue)
        
        
    }

    
    private func playUISelectionFeedbackGeneratorVibrate(){
        (currentUIFeedbackGenerator as! UISelectionFeedbackGenerator).selectionChanged()
    
    }
    
    private func playUINotificationFeedbackGeneratorVibrate(typeID:Int){
        switch typeID {
        case 0:
            (currentUIFeedbackGenerator as! UINotificationFeedbackGenerator).notificationOccurred(.success)
            break
        case 1:
            (currentUIFeedbackGenerator as! UINotificationFeedbackGenerator).notificationOccurred(.error)
            break
        case 2:
            (currentUIFeedbackGenerator as! UINotificationFeedbackGenerator).notificationOccurred(.warning)
            break
        default:
            break
        }
    
    }
    
        private func playVibrate(typeID:Int){
            
            guard CHHapticEngine.capabilitiesForHardware().supportsHaptics
            else {
                return
            }

            
            switch typeID {
            case 0:
                do {
                
                    let param1:[CHHapticEventParameter] = createParamForHapticeEngine(intensity: 1.0
                                                                                      , sharpness: 1.0
                                                                                      , sustained: 1.0
                                                                                      , attackTime: 0.0
                                                                                      , decayTime: 0.1
                                                                                      , releaseTime: 0.0)
                    let event1 = CHHapticEvent(eventType: .hapticTransient
                                              , parameters:param1
                                              , relativeTime: 0)
                    
                    let param2:[CHHapticEventParameter] = createParamForHapticeEngine(intensity: 0.7
                                                                                      , sharpness: 1.0
                                                                                      , sustained: 1.0
                                                                                      , attackTime: 0.0
                                                                                      , decayTime: 0.1
                                                                                      , releaseTime: 0.0)
                    let event2 = CHHapticEvent(eventType: .hapticTransient
                                              , parameters:param2
                                               , relativeTime: 0.32)
                    
                    let param3:[CHHapticEventParameter] = createParamForHapticeEngine(intensity: 1.0
                                                                                      , sharpness: 1.0
                                                                                      , sustained: 1.0
                                                                                      , attackTime: 0.0
                                                                                      , decayTime: 0.1
                                                                                      , releaseTime: 0.0)
                    let event3 = CHHapticEvent(eventType: .hapticTransient
                                              , parameters:param3
                                               , relativeTime: 0.63)
                    
                    
                    playVibrateOnHapticeEngine(events: [event1,event2,event3],dynamicParmeters: [])
      
                }
                
                break
            case 1:
                
                break
            case 2:
                
                break
            default:
                break
            }
        
        }

    
    private func createParamForHapticeEngine(intensity:Float
                                             ,sharpness:Float
                                             ,sustained:Float
                                             ,attackTime:Float
                                             ,decayTime:Float
                                             ,releaseTime:Float)->[CHHapticEventParameter] {
        let intensityParam = CHHapticEventParameter(parameterID: .hapticIntensity, value: intensity)
        let sharpnessParam = CHHapticEventParameter(parameterID: .hapticSharpness, value: sharpness)
        let attackTimeParam = CHHapticEventParameter(parameterID: .attackTime, value: attackTime)
        let sustainedParam = CHHapticEventParameter(parameterID: .sustained, value: sustained)
        let decayTimeParam = CHHapticEventParameter(parameterID: .decayTime, value: decayTime)
        let releaseTimeParam = CHHapticEventParameter(parameterID: .releaseTime, value: releaseTime)
        
        
        let params:[CHHapticEventParameter] = [intensityParam
                                               ,sharpnessParam
                                               ,sustainedParam
                                               ,attackTimeParam
                                               ,decayTimeParam
                                               ,releaseTimeParam]
        
        
        return params
    }
    
    
    /// HapticEngine上で再生します
    /// - Parameters:
    ///   - events:
    ///   - dynamicParmeters:
    private func playVibrateOnHapticeEngine(events: [CHHapticEvent],dynamicParmeters: [CHHapticDynamicParameter]){
        if(currenthapticEngine == nil){
            do {
                
                currenthapticEngine = try CHHapticEngine()
                try currenthapticEngine?.start()
            } catch {
                return
            }
        }
        
        
        do {
            let hapticPattern = try CHHapticPattern(events: events, parameters: dynamicParmeters)
            let hapticPlayer = try currenthapticEngine?.makePlayer(with: hapticPattern)
            try hapticPlayer?.start(atTime: CHHapticTimeImmediate)
        } catch let error{
            return
        }
        
        

    }
    
    
    
}
