using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX_manager : MonoBehaviour
{
    public static AudioClip interact;
    static AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        interact = Resources.Load<AudioClip> ("Pickup_1");
        
        audiosource = GetComponent<AudioSource> ();
        
    }

    
        
    public static void PlaySound (string clip)
    {
        switch (clip){
            case "Pickup_1":
            audiosource.PlayOneShot (interact);
            break;
        }

    }
}
