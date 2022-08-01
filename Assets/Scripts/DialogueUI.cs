using TMPro;
using UnityEngine;
using System;
using System.Collections;

public class DialogueUI : MonoBehaviour
{
    [SerializeField] private GameObject Dialoguebox;
    [SerializeField] private TMP_Text textLablel;
    

    public bool IsOpen  { get; private set; }

    private Response_manager response_Manager;

    private TypewriterEffect typewriterEffect;

    private void Start()
    {
        typewriterEffect = GetComponent<TypewriterEffect>();
        response_Manager = GetComponent<Response_manager>();
        closeDialoguebox();
    }
    
    public void ShowDialogue(DialogueObject dialogueObject)
    {
        IsOpen = true;
        Dialoguebox.SetActive(true);
        StartCoroutine(StepThroughDialogue(dialogueObject));
    }
    
    private IEnumerator StepThroughDialogue(DialogueObject dialogueObject)
    {
        
        for (int i = 0 ; i < dialogueObject.Dialogue.Length; i++)
        {
            string dialogue = dialogueObject.Dialogue[i];
            yield return typewriterEffect.Run(dialogue, textLablel);

            if( i == dialogueObject.Dialogue.Length - 1 && dialogueObject.HasResponses) break;
            
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        }

        if (dialogueObject.HasResponses)
        {
            response_Manager.ShowResponses(dialogueObject.Responses);
        }
        else
        {
            closeDialoguebox();
        }

        
    }

    private void closeDialoguebox()
    {
        IsOpen = false;
        Dialoguebox.SetActive(false);
        textLablel.text = string.Empty;
    }
}
