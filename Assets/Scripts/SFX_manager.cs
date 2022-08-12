using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX_manager : MonoBehaviour
{
    public static AudioClip Interact;
    static AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        Interact = Resources.Load<AudioClip> ("Pickup_1");
        
        audiosource = GetComponent<AudioSource> ();
        
    }

    // Update is called once per frame
    void Update()
    {}
        
    
    public static void PlaySound (string clip)
    {
        switch (clip){
            case "Pickup_1":
            audiosource.PlayOneShot (Interact);
            break;
        }

    }
}
