using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject Dialogue_box;

    public Text Dialoguetext;

    public string dialogue;
    public bool PlayerInRange;

    void Start (){

    }

    void Update (){
        if (Input.GetKey(KeyCode.Space) && PlayerInRange)
        {
            if(Dialogue_box.activeInHierarchy)
            {
                Dialogue_box.SetActive(false);

            }
            else {
                Dialogue_box.SetActive(true);
                Dialoguetext.text = dialogue;
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Player"))
        {
            PlayerInRange = true;

        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInRange = false;
        }
    }

}
