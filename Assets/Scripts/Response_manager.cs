using TMPro;
using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Response_manager : MonoBehaviour
{
   [SerializeField] private RectTransform ResponseBox;
   [SerializeField] private RectTransform responseButtonTemplate;
   [SerializeField] private RectTransform responseContainer;

   private DialogueUI dialogueUI;
   
   private List<GameObject> tempResponseButtons = new List<GameObject>();

   private void Start()
   {
    dialogueUI=GetComponent<DialogueUI>();
   }
   public void ShowResponses (Response[] responses)
   {
        float responseBoxHeight = 0; 

        foreach (Response response in responses)
        {
            GameObject responseButton = Instantiate(responseButtonTemplate.gameObject, responseContainer);
            responseButton.gameObject.SetActive(true);
            responseButton.GetComponent<TMP_Text>().text = response.ResponseText;
            responseButton.GetComponent<Button>().onClick.AddListener(() => OnPickedResponse(response));

            tempResponseButtons.Add(responseButton);

            responseBoxHeight += responseButtonTemplate.sizeDelta.y;
        }

        ResponseBox.sizeDelta = new Vector2(ResponseBox.sizeDelta.x, responseBoxHeight);
        ResponseBox.gameObject.SetActive(true);
   }

   private void OnPickedResponse(Response response)
   {
    ResponseBox.gameObject.SetActive(false);

    foreach (GameObject button in tempResponseButtons)
    {
        Destroy(button);
    }
    tempResponseButtons.Clear();

    dialogueUI.ShowDialogue(response.DialogueObject);

   }

}
