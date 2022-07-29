using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;

public class Dialogue_manager : MonoBehaviour
{

    [Header("Dialogue UI")]
    [SerializeField] private GameObject Dialogue_panel;
    [SerializeField] private TextMeshProUGUI Dialogue_text;
    private Story currentStory;
    private bool dialogueIsPlaying;
    private static Dialogue_manager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Dialogue Manager in the scene");

        }
        instance = this;
    }

    public static Dialogue_manager GetInstance()
    {
        return instance;
    }

    private void Start()
    {
        dialogueIsPlaying = false;
        Dialogue_panel.SetActive(false);
    }

    private void Update()
    {
        // return right away if the dialoue is not playing
        if (!dialogueIsPlaying)
        {
            return;
        }
        // handle the continuing to the next line in the dialogue when submit is pressed
        if (Input_manager.GetInstance().GetSubmitPressed())
        {
            ContiuneStory();

        }
    }

    public void EnterDialogueMode(TextAsset inkJSON)    
    {
        currentStory = new Story (inkJSON.text);
        dialogueIsPlaying = true;
        Dialogue_panel.SetActive(true);

        ContiuneStory();
    }

    private void ExitDialogueMode()
    {
        dialogueIsPlaying =false;
        Dialogue_panel.SetActive(false);
        Dialogue_text.text = "";
    }
    
    private void ContiuneStory()
    {
        if (currentStory.canContinue)
        {
            // set text for the current dialogue line
            Dialogue_text.text = currentStory.Continue();

        }
        else
        {
            ExitDialogueMode();

        }

    }
}
