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
                
                    let event1 = selectEventForHapticeEngine(paramNum: 0,relativeTime: 0.0)
                    let event2 = selectEventForHapticeEngine(paramNum: 1,relativeTime: 0.1)
                    let event3 = selectEventForHapticeEngine(paramNum: 0,relativeTime: 0.13)
                    
                    playVibrateOnHapticeEngine(events: [event1,event2,event3],dynamicParmeters: [])
      
                }
                
                break
            case 1:
                do {
                
                    let event1 = selectEventForHapticeEngine(paramNum: 0,relativeTime: 0.0)
                    let event2 = selectEventForHapticeEngine(paramNum: 2,relativeTime: 0.03)
                    let event3 = selectEventForHapticeEngine(paramNum: 3,relativeTime: 0.09)
                    
                    playVibrateOnHapticeEngine(events: [event1,event2,event3],dynamicParmeters: [])
      
                }
                
                break
            case 2:
                do {
                
                    let event1 = selectEventForHapticeEngine(paramNum: 0,relativeTime: 0.0)
                    let event2 = selectEventForHapticeEngine(paramNum: 4,relativeTime: 0.1)
                    let event3 = selectEventForHapticeEngine(paramNum: 101,relativeTime: 0.43)
                    
                    playVibrateOnHapticeEngine(events: [event1,event2,event3],dynamicParmeters: [])
      
                }
                
                break
                
                
            case 3:
                do {
                
                    let event1 = selectEventForHapticeEngine(paramNum: 103,relativeTime: 0.10)
                    let event2 = selectEventForHapticeEngine(paramNum: 104,relativeTime: 0.1)
                    let event3 = selectEventForHapticeEngine(paramNum: 103,relativeTime: 0.12)
                    let event4 = selectEventForHapticeEngine(paramNum: 104,relativeTime: 0.22)
                    let event5 = selectEventForHapticeEngine(paramNum: 103,relativeTime: 0.33)
                    let event6 = selectEventForHapticeEngine(paramNum: 104,relativeTime: 0.44)
                    
                    playVibrateOnHapticeEngine(events: [event1,event2,event3,event4,event5,event6],dynamicParmeters: [])
      
                }
                
                break
                
                
            case 4:
                do {
                
                    let event1 = selectEventForHapticeEngine(paramNum: 0,relativeTime: 0.0)
                    let event2 = selectEventForHapticeEngine(paramNum: 4,relativeTime: 0.03)
                    let event3 = selectEventForHapticeEngine(paramNum: 101,relativeTime: 0.07)
                    let event4 = selectEventForHapticeEngine(paramNum: 0,relativeTime: 0.09)
                    let event5 = selectEventForHapticeEngine(paramNum: 4,relativeTime: 0.13)
                    let event6 = selectEventForHapticeEngine(paramNum: 101,relativeTime: 0.15)
                    let event7 = selectEventForHapticeEngine(paramNum: 0,relativeTime: 0.18)
                    let event8 = selectEventForHapticeEngine(paramNum: 4,relativeTime: 0.2)
                    let event9 = selectEventForHapticeEngine(paramNum: 101,relativeTime: 0.23)
                    
                    playVibrateOnHapticeEngine(events: [event1,event2,event3,event4,event5,event6,event7,event8,event9],dynamicParmeters: [])
      
                }
                
                break
                
            case 5:
                do {
                
                    let event1 = selectEventForHapticeEngine(paramNum: 5,relativeTime: 0.0)
                    let event2 = selectEventForHapticeEngine(paramNum: 6,relativeTime: 0.1)
                    let event3 = selectEventForHapticeEngine(paramNum: 7,relativeTime: 0.43)
                    
                    playVibrateOnHapticeEngine(events: [event1,event2,event3],dynamicParmeters: [])
      
                }
                
                break
                
            case 6:
                do {
                
                    let event1 = selectEventForHapticeEngine(paramNum: 0,relativeTime: 0.0)
                    let event2 = selectEventForHapticeEngine(paramNum: 4,relativeTime: 0.03)
                    let event3 = selectEventForHapticeEngine(paramNum: 101,relativeTime: 0.07)
                    let event4 = selectEventForHapticeEngine(paramNum: 1,relativeTime: 0.09)
                    let event5 = selectEventForHapticeEngine(paramNum: 4,relativeTime: 0.13)
                    let event6 = selectEventForHapticeEngine(paramNum: 105,relativeTime: 0.15)
                    let event7 = selectEventForHapticeEngine(paramNum: 1,relativeTime: 0.18)
                    let event8 = selectEventForHapticeEngine(paramNum: 4,relativeTime: 0.2)
                    let event9 = selectEventForHapticeEngine(paramNum: 103,relativeTime: 0.23)
                    
                    playVibrateOnHapticeEngine(events: [event1,event2,event3,event4,event5,event6,event7,event8,event9],dynamicParmeters: [])
                }
                
                break
            case 7:
                do {
                
                    let event1 = selectEventForHapticeEngine(paramNum: 0,relativeTime: 0.0)
                    let event2 = selectEventForHapticeEngine(paramNum: 4,relativeTime: 0.03)
                    let event3 = selectEventForHapticeEngine(paramNum: 101,relativeTime: 0.07)
                    let event4 = selectEventForHapticeEngine(paramNum: 1,relativeTime: 0.09)
                    let event5 = selectEventForHapticeEngine(paramNum: 102,relativeTime: 0.13)
                    let event6 = selectEventForHapticeEngine(paramNum: 103,relativeTime: 0.15)
                    let event7 = selectEventForHapticeEngine(paramNum: 102,relativeTime: 0.3)
                    let event8 = selectEventForHapticeEngine(paramNum: 103,relativeTime: 0.5)
                    let event9 = selectEventForHapticeEngine(paramNum: 103,relativeTime: 0.8)
                    
                    playVibrateOnHapticeEngine(events: [event1,event2,event3,event4,event5,event6,event7,event8,event9],dynamicParmeters: [])
                }
                
                break
            case 8:
                do {
                
                    let event1 = selectEventForHapticeEngine(paramNum: 0,relativeTime: 0.0)
                    let event2 = selectEventForHapticeEngine(paramNum: 3,relativeTime: 0.03)
                    let event3 = selectEventForHapticeEngine(paramNum: 1,relativeTime: 0.07)
                    let event4 = selectEventForHapticeEngine(paramNum: 3,relativeTime: 0.09)
                    let event5 = selectEventForHapticeEngine(paramNum: 1,relativeTime: 0.13)
                    let event6 = selectEventForHapticeEngine(paramNum: 6,relativeTime: 0.15)
                    let event7 = selectEventForHapticeEngine(paramNum: 5,relativeTime: 0.3)
                    let event8 = selectEventForHapticeEngine(paramNum: 6,relativeTime: 0.5)
                    let event9 = selectEventForHapticeEngine(paramNum: 5,relativeTime: 0.8)
                    
                    playVibrateOnHapticeEngine(events: [event1,event2,event3,event4,event5,event6,event7,event8,event9],dynamicParmeters: [])
                }
                
                break
                
            case 9:
                do {
                
                    let event1 = selectEventForHapticeEngine(paramNum: 7,relativeTime: 0.0)
                    let event2 = selectEventForHapticeEngine(paramNum: 8,relativeTime: 0.03)
                    let event3 = selectEventForHapticeEngine(paramNum: 8,relativeTime: 0.09)
                    let event4 = selectEventForHapticeEngine(paramNum: 9,relativeTime: 0.12)
                    let event5 = selectEventForHapticeEngine(paramNum: 5,relativeTime: 0.15)
                    let event6 = selectEventForHapticeEngine(paramNum: 6,relativeTime: 0.18)
                    let event7 = selectEventForHapticeEngine(paramNum: 5,relativeTime: 0.19)
                    let event8 = selectEventForHapticeEngine(paramNum: 6,relativeTime: 0.21)
                    let event9 = selectEventForHapticeEngine(paramNum: 5,relativeTime: 0.24)
                    
                    playVibrateOnHapticeEngine(events: [event1,event2,event3,event4,event5,event6,event7,event8,event9],dynamicParmeters: [])
                }
                
                break
                
            case 10:
                do {
                
                    let event1 = selectEventForHapticeEngine(paramNum: 101,relativeTime: 0.01)
                    let event2 = selectEventForHapticeEngine(paramNum: 102,relativeTime: 0.03)
                    let event3 = selectEventForHapticeEngine(paramNum: 101,relativeTime: 0.07)
                    let event4 = selectEventForHapticeEngine(paramNum: 101,relativeTime: 0.09)
                    let event5 = selectEventForHapticeEngine(paramNum: 101,relativeTime: 0.13)
                    let event6 = selectEventForHapticeEngine(paramNum: 101,relativeTime: 0.15)
                    let event7 = selectEventForHapticeEngine(paramNum: 105,relativeTime: 0.3)
                    let event8 = selectEventForHapticeEngine(paramNum: 106,relativeTime: 0.5)
                    let event9 = selectEventForHapticeEngine(paramNum: 105,relativeTime: 0.8)
                    
                    playVibrateOnHapticeEngine(events: [event1,event2,event3,event4,event5,event6,event7,event8,event9],dynamicParmeters: [])
                }
                
                break
                
            case 11:
                do {
                
                    let event1 = selectEventForHapticeEngine(paramNum: 106,relativeTime: 0.01)
                    let event2 = selectEventForHapticeEngine(paramNum: 107,relativeTime: 0.03)
                    let event3 = selectEventForHapticeEngine(paramNum: 106,relativeTime: 0.07)
                    let event4 = selectEventForHapticeEngine(paramNum: 107,relativeTime: 0.08)
                    let event5 = selectEventForHapticeEngine(paramNum: 103,relativeTime: 0.09)
                    let event6 = selectEventForHapticeEngine(paramNum: 103,relativeTime: 0.10)
                    let event7 = selectEventForHapticeEngine(paramNum: 104,relativeTime: 0.20)
                    let event8 = selectEventForHapticeEngine(paramNum: 104,relativeTime: 0.30)
                    let event9 = selectEventForHapticeEngine(paramNum: 104,relativeTime: 0.40)
                    
                    playVibrateOnHapticeEngine(events: [event1,event2,event3,event4,event5,event6,event7,event8,event9],dynamicParmeters: [])
                }
                
                break
                
            case 12:
                do {
                
                    let event1 = selectEventForHapticeEngine(paramNum: 0,relativeTime: 0.0)
                    let event2 = selectEventForHapticeEngine(paramNum: 3,relativeTime: 0.03)
                    let event3 = selectEventForHapticeEngine(paramNum: 1,relativeTime: 0.07)
                    let event4 = selectEventForHapticeEngine(paramNum: 3,relativeTime: 0.09)
                    let event5 = selectEventForHapticeEngine(paramNum: 1,relativeTime: 0.10)
                    let event6 = selectEventForHapticeEngine(paramNum: 10,relativeTime: 0.08)
                    let event7 = selectEventForHapticeEngine(paramNum: 7,relativeTime: 0.3)
                    let event8 = selectEventForHapticeEngine(paramNum: 10,relativeTime: 0.5)
                    let event9 = selectEventForHapticeEngine(paramNum: 7,relativeTime: 0.8)
                    
                    playVibrateOnHapticeEngine(events: [event1,event2,event3,event4,event5,event6,event7,event8,event9],dynamicParmeters: [])
                }
                
                break
                
            case 13:
                do {
                
                    let event1 = selectEventForHapticeEngine(paramNum: 0,relativeTime: 0.0)
                    let event2 = selectEventForHapticeEngine(paramNum: 9,relativeTime: 0.03)
                    let event3 = selectEventForHapticeEngine(paramNum: 1,relativeTime: 0.04)
                    let event4 = selectEventForHapticeEngine(paramNum: 9,relativeTime: 0.07)
                    let event5 = selectEventForHapticeEngine(paramNum: 1,relativeTime: 0.12)
                    let event6 = selectEventForHapticeEngine(paramNum: 10,relativeTime: 0.15)
                    let event7 = selectEventForHapticeEngine(paramNum: 5,relativeTime: 0.3)
                    let event8 = selectEventForHapticeEngine(paramNum: 10,relativeTime: 0.4)
                    let event9 = selectEventForHapticeEngine(paramNum: 5,relativeTime: 0.55)
                    
                    playVibrateOnHapticeEngine(events: [event1,event2,event3,event4,event5,event6,event7,event8,event9],dynamicParmeters: [])
                }
                
                break
                
            case 14:
                do {
                
                    let event1 = selectEventForHapticeEngine(paramNum: 1,relativeTime: 0.0)
                    let event2 = selectEventForHapticeEngine(paramNum: 3,relativeTime: 0.03)
                    let event3 = selectEventForHapticeEngine(paramNum: 1,relativeTime: 0.07)
                    let event4 = selectEventForHapticeEngine(paramNum: 3,relativeTime: 0.09)
                    let event5 = selectEventForHapticeEngine(paramNum: 1,relativeTime: 0.10)
                    let event6 = selectEventForHapticeEngine(paramNum: 10,relativeTime: 0.08)
                    let event7 = selectEventForHapticeEngine(paramNum: 5,relativeTime: 0.2)
                    let event8 = selectEventForHapticeEngine(paramNum: 6,relativeTime: 0.3)
                    let event9 = selectEventForHapticeEngine(paramNum: 5,relativeTime: 0.5)
                    
                    playVibrateOnHapticeEngine(events: [event1,event2,event3,event4,event5,event6,event7,event8,event9],dynamicParmeters: [])
                }
                
                break
                
                
            case 15:
                do {
                
                    let event1 = selectEventForHapticeEngine(paramNum: 8,relativeTime: 0.0)
                    let event2 = selectEventForHapticeEngine(paramNum: 3,relativeTime: 0.03)
                    let event3 = selectEventForHapticeEngine(paramNum: 8,relativeTime: 0.07)
                    let event4 = selectEventForHapticeEngine(paramNum: 3,relativeTime: 0.12)
                    let event4_1 = selectEventForHapticeEngine(paramNum: 8,relativeTime: 0.15)
                    let event4_2 = selectEventForHapticeEngine(paramNum: 3,relativeTime: 0.18)
                    let event5 = selectEventForHapticeEngine(paramNum: 8,relativeTime: 0.21)
                    let event6 = selectEventForHapticeEngine(paramNum: 0,relativeTime: 0.24)
                    let event7 = selectEventForHapticeEngine(paramNum: 5,relativeTime: 0.29)
                    let event8 = selectEventForHapticeEngine(paramNum: 6,relativeTime: 0.32)
                    let event9 = selectEventForHapticeEngine(paramNum: 5,relativeTime: 0.38)
                    
                    playVibrateOnHapticeEngine(events: [event1,event2,event3,event4,event4_1,event4_2,event5,event6,event7,event8,event9],dynamicParmeters: [])
                }
                
                break
            case 16:
                do {
                
                    let event1 = selectEventForHapticeEngine(paramNum: 8,relativeTime: 0.0)
                    let event2 = selectEventForHapticeEngine(paramNum: 3,relativeTime: 0.03)
                    let event3 = selectEventForHapticeEngine(paramNum: 8,relativeTime: 0.07)
                    let event4 = selectEventForHapticeEngine(paramNum: 3,relativeTime: 0.09)
                    let event5 = selectEventForHapticeEngine(paramNum: 8,relativeTime: 0.10)
                    let event6 = selectEventForHapticeEngine(paramNum: 0,relativeTime: 0.13)
                    let event7 = selectEventForHapticeEngine(paramNum: 5,relativeTime: 0.16)
                    let event8 = selectEventForHapticeEngine(paramNum: 6,relativeTime: 0.21)
                    let event9 = selectEventForHapticeEngine(paramNum: 5,relativeTime: 0.25)
                    
                    playVibrateOnHapticeEngine(events: [event1,event2,event3,event4,event5,event6,event7,event8,event9],dynamicParmeters: [])
                }
                
                break
                
            case 17:
                do {
                
                    let event1 = selectEventForHapticeEngine(paramNum: 1,relativeTime: 0.0)
                    let event2 = selectEventForHapticeEngine(paramNum: 2,relativeTime: 0.13)
                    let event3 = selectEventForHapticeEngine(paramNum: 1,relativeTime: 0.26)
                    let event4 = selectEventForHapticeEngine(paramNum: 2,relativeTime: 0.39)
                    let event5 = selectEventForHapticeEngine(paramNum: 1,relativeTime: 0.42)
                    let event6 = selectEventForHapticeEngine(paramNum: 2,relativeTime: 0.55)
                    let event7 = selectEventForHapticeEngine(paramNum: 1,relativeTime: 0.68)
                    let event8 = selectEventForHapticeEngine(paramNum: 2,relativeTime: 0.71)
                    let event9 = selectEventForHapticeEngine(paramNum: 1,relativeTime: 0.84)
                    
                    playVibrateOnHapticeEngine(events: [event1,event2,event3,event4,event5,event6,event7,event8,event9],dynamicParmeters: [])
                }
                
                break
                
                
            case 18:
                do {
                
                    let event1 = selectEventForHapticeEngine(paramNum: 4,relativeTime: 0.0)
                    let event2 = selectEventForHapticeEngine(paramNum: 2,relativeTime: 0.10)
                    let event3 = selectEventForHapticeEngine(paramNum: 4,relativeTime: 0.20)
                    let event4 = selectEventForHapticeEngine(paramNum: 2,relativeTime: 0.30)
                    let event5 = selectEventForHapticeEngine(paramNum: 4,relativeTime: 0.40)
                    let event6 = selectEventForHapticeEngine(paramNum: 2,relativeTime: 0.50)
                    let event7 = selectEventForHapticeEngine(paramNum: 4,relativeTime: 0.60)
                    let event8 = selectEventForHapticeEngine(paramNum: 2,relativeTime: 0.70)
                    let event9 = selectEventForHapticeEngine(paramNum: 4,relativeTime: 0.80)
                    
                    playVibrateOnHapticeEngine(events: [event1,event2,event3,event4,event5,event6,event7,event8,event9],dynamicParmeters: [])
                }
                
                break
                
            case 19:
                do {
                
                    let event1 = selectEventForHapticeEngine(paramNum: 9,relativeTime: 0.0)
                    let event2 = selectEventForHapticeEngine(paramNum: 2,relativeTime: 0.10)
                    let event3 = selectEventForHapticeEngine(paramNum: 9,relativeTime: 0.20)
                    let event4 = selectEventForHapticeEngine(paramNum: 2,relativeTime: 0.30)
                    let event5 = selectEventForHapticeEngine(paramNum: 9,relativeTime: 0.40)
                    let event6 = selectEventForHapticeEngine(paramNum: 2,relativeTime: 0.50)
                    let event7 = selectEventForHapticeEngine(paramNum: 9,relativeTime: 0.60)
                    let event8 = selectEventForHapticeEngine(paramNum: 2,relativeTime: 0.70)
                    let event9 = selectEventForHapticeEngine(paramNum: 9,relativeTime: 0.80)
                    
                    playVibrateOnHapticeEngine(events: [event1,event2,event3,event4,event5,event6,event7,event8,event9],dynamicParmeters: [])
                }
                
                break
                
            case 20:
                do {
                
                    let event1 = selectEventForHapticeEngine(paramNum: 10,relativeTime: 0.0)
                    let event2 = selectEventForHapticeEngine(paramNum: 2,relativeTime: 0.10)
                    let event3 = selectEventForHapticeEngine(paramNum: 10,relativeTime: 0.20)
                    let event4 = selectEventForHapticeEngine(paramNum: 2,relativeTime: 0.30)
                    let event5 = selectEventForHapticeEngine(paramNum: 10,relativeTime: 0.40)
                    let event6 = selectEventForHapticeEngine(paramNum: 2,relativeTime: 0.50)
                    let event7 = selectEventForHapticeEngine(paramNum: 10,relativeTime: 0.60)
                    let event8 = selectEventForHapticeEngine(paramNum: 2,relativeTime: 0.70)
                    let event9 = selectEventForHapticeEngine(paramNum: 10,relativeTime: 0.80)
                    
                    playVibrateOnHapticeEngine(events: [event1,event2,event3,event4,event5,event6,event7,event8,event9],dynamicParmeters: [])
                }
                
                break
            case 21:
                do {
                
                    let event1 = selectEventForHapticeEngine(paramNum: 1,relativeTime: 0.0)
                    let event2 = selectEventForHapticeEngine(paramNum: 2,relativeTime: 0.10)
                    let event3 = selectEventForHapticeEngine(paramNum: 4,relativeTime: 0.20)
                    let event4 = selectEventForHapticeEngine(paramNum: 2,relativeTime: 0.30)
                    let event5 = selectEventForHapticeEngine(paramNum: 9,relativeTime: 0.40)
                    let event6 = selectEventForHapticeEngine(paramNum: 2,relativeTime: 0.50)
                    let event7 = selectEventForHapticeEngine(paramNum: 10,relativeTime: 0.60)
                    let event8 = selectEventForHapticeEngine(paramNum: 2,relativeTime: 0.70)
                    let event9 = selectEventForHapticeEngine(paramNum: 10,relativeTime: 0.80)
                    
                    playVibrateOnHapticeEngine(events: [event1,event2,event3,event4,event5,event6,event7,event8,event9],dynamicParmeters: [])
                }
                
                break
                
            default:
                break
            }
        
        }
    
    
    private func selectEventForHapticeEngine(paramNum:Int,relativeTime:Float)->CHHapticEvent{
        
        var paramHapticEvent:CHHapticEvent = CHHapticEvent(eventType: .hapticTransient
                                                                , parameters:[]
                                                                , relativeTime: 0.0)
        
        switch paramNum {
        case 0:
            let param:[CHHapticEventParameter] = selectParamForHapticeEngine(paramNum: 0)
            paramHapticEvent = CHHapticEvent(eventType: .hapticTransient
                                                                , parameters:param
                                             , relativeTime: TimeInterval(relativeTime))
            break
        case 1:
            let param:[CHHapticEventParameter] = selectParamForHapticeEngine(paramNum: 1)
            paramHapticEvent = CHHapticEvent(eventType: .hapticTransient
                                                                , parameters:param
                                             , relativeTime: TimeInterval(relativeTime))
            break
        case 2:
            let param:[CHHapticEventParameter] = selectParamForHapticeEngine(paramNum: 2)
            paramHapticEvent = CHHapticEvent(eventType: .hapticTransient
                                                                , parameters:param
                                             , relativeTime: TimeInterval(relativeTime))
            break
        case 3:
            let param:[CHHapticEventParameter] = selectParamForHapticeEngine(paramNum: 3)
            paramHapticEvent = CHHapticEvent(eventType: .hapticTransient
                                                                , parameters:param
                                             , relativeTime: TimeInterval(relativeTime))
            break
            
        case 4:
            let param:[CHHapticEventParameter] = selectParamForHapticeEngine(paramNum: 4)
            paramHapticEvent = CHHapticEvent(eventType: .hapticTransient
                                                                , parameters:param
                                             , relativeTime: TimeInterval(relativeTime))
            break
        case 5:
            let param:[CHHapticEventParameter] = selectParamForHapticeEngine(paramNum: 5)
            paramHapticEvent = CHHapticEvent(eventType: .hapticTransient
                                                                , parameters:param
                                             , relativeTime: TimeInterval(relativeTime))
            break
        case 6:
            let param:[CHHapticEventParameter] = selectParamForHapticeEngine(paramNum: 6)
            paramHapticEvent = CHHapticEvent(eventType: .hapticTransient
                                                                , parameters:param
                                             , relativeTime: TimeInterval(relativeTime))
            break
        case 7:
            let param:[CHHapticEventParameter] = selectParamForHapticeEngine(paramNum: 7)
            paramHapticEvent = CHHapticEvent(eventType: .hapticTransient
                                                                , parameters:param
                                             , relativeTime: TimeInterval(relativeTime))
            break
        case 8:
            let param:[CHHapticEventParameter] = selectParamForHapticeEngine(paramNum: 8)
            paramHapticEvent = CHHapticEvent(eventType: .hapticTransient
                                                                , parameters:param
                                             , relativeTime: TimeInterval(relativeTime))
            break
        case 9:
            let param:[CHHapticEventParameter] = selectParamForHapticeEngine(paramNum: 9)
            paramHapticEvent = CHHapticEvent(eventType: .hapticTransient
                                                                , parameters:param
                                             , relativeTime: TimeInterval(relativeTime))
            break
        case 10:
            let param:[CHHapticEventParameter] = selectParamForHapticeEngine(paramNum: 10)
            paramHapticEvent = CHHapticEvent(eventType: .hapticTransient
                                                                , parameters:param
                                             , relativeTime: TimeInterval(relativeTime))
            break
            
            
            
            
            
            
            
            //
            // 継続系
            //
        case 100:
            let param:[CHHapticEventParameter] = selectParamForHapticeEngine(paramNum: 0)
            paramHapticEvent = CHHapticEvent(eventType: .hapticContinuous
                                                                , parameters:param
                                             , relativeTime: TimeInterval(relativeTime)
                                            ,duration: TimeInterval(relativeTime/2))
            break
        case 101:
            let param:[CHHapticEventParameter] = selectParamForHapticeEngine(paramNum: 1)
            paramHapticEvent = CHHapticEvent(eventType: .hapticContinuous
                                                                , parameters:param
                                             , relativeTime: TimeInterval(relativeTime)
                                             ,duration: TimeInterval(relativeTime/2))
            break
            
        case 102:
            let param:[CHHapticEventParameter] = selectParamForHapticeEngine(paramNum: 2)
            paramHapticEvent = CHHapticEvent(eventType: .hapticContinuous
                                                                , parameters:param
                                             , relativeTime: TimeInterval(relativeTime)
                                             ,duration: TimeInterval(relativeTime/2))
            break
            
        case 103:
            let param:[CHHapticEventParameter] = selectParamForHapticeEngine(paramNum: 3)
            paramHapticEvent = CHHapticEvent(eventType: .hapticContinuous
                                                                , parameters:param
                                             , relativeTime: TimeInterval(relativeTime)
                                             ,duration: TimeInterval(relativeTime/2))
            break
            
        case 104:
            let param:[CHHapticEventParameter] = selectParamForHapticeEngine(paramNum: 4)
            paramHapticEvent = CHHapticEvent(eventType: .hapticContinuous
                                                                , parameters:param
                                             , relativeTime: TimeInterval(relativeTime)
                                             ,duration: TimeInterval(relativeTime/2))
            break
            
        case 105:
            let param:[CHHapticEventParameter] = selectParamForHapticeEngine(paramNum: 5)
            paramHapticEvent = CHHapticEvent(eventType: .hapticContinuous
                                                                , parameters:param
                                             , relativeTime: TimeInterval(relativeTime)
                                             ,duration: TimeInterval(relativeTime/2))
            break
        case 106:
            let param:[CHHapticEventParameter] = selectParamForHapticeEngine(paramNum: 6)
            paramHapticEvent = CHHapticEvent(eventType: .hapticContinuous
                                                                , parameters:param
                                             , relativeTime: TimeInterval(relativeTime)
                                             ,duration: TimeInterval(relativeTime/2))
            break
        case 107:
            let param:[CHHapticEventParameter] = selectParamForHapticeEngine(paramNum: 7)
            paramHapticEvent = CHHapticEvent(eventType: .hapticContinuous
                                                                , parameters:param
                                             , relativeTime: TimeInterval(relativeTime)
                                             ,duration: TimeInterval(relativeTime/2))
            break
        case 108:
            let param:[CHHapticEventParameter] = selectParamForHapticeEngine(paramNum: 8)
            paramHapticEvent = CHHapticEvent(eventType: .hapticContinuous
                                                                , parameters:param
                                             , relativeTime: TimeInterval(relativeTime)
                                             ,duration: TimeInterval(relativeTime/1.1))
            break
        case 109:
            let param:[CHHapticEventParameter] = selectParamForHapticeEngine(paramNum: 9)
            paramHapticEvent = CHHapticEvent(eventType: .hapticContinuous
                                                                , parameters:param
                                             , relativeTime: TimeInterval(relativeTime)
                                             ,duration: TimeInterval(relativeTime/1.1))
            break
        case 110:
            let param:[CHHapticEventParameter] = selectParamForHapticeEngine(paramNum: 10)
            paramHapticEvent = CHHapticEvent(eventType: .hapticContinuous
                                                                , parameters:param
                                             , relativeTime: TimeInterval(relativeTime)
                                             ,duration: TimeInterval(relativeTime/1.1))
            break
            
            
            
            
            
            
            
            
        default:
            break
        }
        
        
        
        
        return paramHapticEvent
    }
    
    
    /// パラメータ一覧から選ぶ
    /// - Parameter paramNum:
    /// - Returns:
    private func selectParamForHapticeEngine(paramNum:Int)->[CHHapticEventParameter]{
        var param:[CHHapticEventParameter] = [];
        
        
        switch paramNum {
        case 0:
            param = createParamForHapticeEngine(intensity: 1.0
                                                , sharpness: 1.0
                                                , sustained: 1.0
                                                , attackTime: 0.0
                                                , decayTime: 0.1
                                                , releaseTime: 0.0)
            break
        case 1:
            param = createParamForHapticeEngine(intensity: 0.2
                                                , sharpness: 1.0
                                                , sustained: 1.0
                                                , attackTime: 0.0
                                                , decayTime: 0.1
                                                , releaseTime: 0.0)
            break
        case 2:
            param = createParamForHapticeEngine(intensity: 0.2
                                                , sharpness: 0.3
                                                , sustained: 1.0
                                                , attackTime: 0.0
                                                , decayTime: 0.1
                                                , releaseTime: 0.0)
            break
        case 3:
            param = createParamForHapticeEngine(intensity: 0.8
                                                , sharpness: 1.0
                                                , sustained: 1.0
                                                , attackTime: 0.0
                                                , decayTime: 0.03
                                                , releaseTime: 0.0)
            break
        case 4:
            param = createParamForHapticeEngine(intensity: 0.5
                                                , sharpness: 0.5
                                                , sustained: 1.0
                                                , attackTime: 0.0
                                                , decayTime: 0.1
                                                , releaseTime: 0.0)
            break
            
        case 5:
            param = createParamForHapticeEngine(intensity: 0.1
                                                , sharpness: 0.1
                                                , sustained: 1.0
                                                , attackTime: 0.0
                                                , decayTime: 0.03
                                                , releaseTime: 0.01)
            break
            
        case 6:
            param = createParamForHapticeEngine(intensity: 1.0
                                                , sharpness: 0.1
                                                , sustained: 1.0
                                                , attackTime: 0.0
                                                , decayTime: 0.1
                                                , releaseTime: 0.0)
            break
            
        case 7:
            param = createParamForHapticeEngine(intensity: 0.01
                                                , sharpness: 1.0
                                                , sustained: 1.0
                                                , attackTime: 0.0
                                                , decayTime: 0.06
                                                , releaseTime: 0.0)
            break
        case 8:
            param = createParamForHapticeEngine(intensity: 0.3
                                                , sharpness: 0.5
                                                , sustained: 1.0
                                                , attackTime: 0.01
                                                , decayTime: 0.03
                                                , releaseTime: 0.01)
            break
        case 9:
            param = createParamForHapticeEngine(intensity: 0.6
                                                , sharpness: 1.0
                                                , sustained: 1.0
                                                , attackTime: 0.01
                                                , decayTime: 0.01
                                                , releaseTime: 0.0)
            break
        case 10:
            param = createParamForHapticeEngine(intensity: 1.0
                                                , sharpness: 1.0
                                                , sustained: 1.0
                                                , attackTime: 0.0
                                                , decayTime: 0.06
                                                , releaseTime: 0.0)
            break
            
        default:
            break
        }
        
        
        
        
        return param
        
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
        
        
        currenthapticEngine?.stoppedHandler = { reason in
            //停止したとき
            //端末スリープすると、停止するようです。
            //復帰できるようにエンジンを開放しておく
            self.currenthapticEngine=nil
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
