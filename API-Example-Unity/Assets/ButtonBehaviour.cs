using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using agora_gaming_rtc;

public class ButtonBehaviour : MonoBehaviour {
   private IRtcEngine mRtcEngine = null;

   public void OnButtonPress(){
      Debug.Log("Button clicked");
      mRtcEngine = IRtcEngine.GetEngine("APP-ID");
      mRtcEngine.SetEnableSpeakerphone(true);
   }
}
