import Foundation

class SyskenTlibVibrateManager{
    
    var currentUIFeedbackGenerator:UIFeedbackGenerator?
    var lastPlayGroupID:Int = -99
    
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
            
            break
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
        let strengthValue = (Double)(strength%101) * 1
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

    
    
    
}
