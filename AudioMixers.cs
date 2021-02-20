using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class AudioMixers : MonoBehaviour {

    public AudioMixer masterMixer;

    
    public void SetGlosnoscEfektow(float sfxLvl)
    {
        
        masterMixer.SetFloat("Master", sfxLvl);
    }
}


