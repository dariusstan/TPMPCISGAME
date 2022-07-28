using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject Visualcue;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    private bool playerInRange;

    private void Awake() 
    {
        playerInRange = false;
        Visualcue.SetActive(false);
    }

    private void Update() 
    {
        if (playerInRange) 
        { 
            Visualcue.SetActive(true); 
            if (Input_manager.GetInstance().GetInteractPressed()) 
            { 
                Debug.Log(inkJSON.text); 
            } 
        } 
        else 
        { 
            Visualcue.SetActive(false);  
        }
        
    
        
    

        
        /*if (playerInRange && !Dialogue_manager.GetInstance().dialogueIsPlaying) 
        {
            Visualcue.SetActive(true);
            if (Input_manager.GetInstance().GetInteractPressed()) 
            {
                Dialogue_manager.GetInstance().EnterDialogueMode(inkJSON);
            }
        }
        else 
        {
            Visualcue.SetActive(false);
        }*/
    }

    private void OnTriggerEnter2D(Collider2D collider) 
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider) 
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }
}
