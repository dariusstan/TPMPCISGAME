using UnityEngine;

[System.Serializable]
public class Response
{
   //responseText originally is private
   [SerializeField] private string responseText;
   [SerializeField] private DialogueObject dialogueObject;
   // [SerializeField] public bool isTrue = false;
   // [SerializeField] public string correctAns;

   public string ResponseText => responseText;

   public DialogueObject DialogueObject => dialogueObject;

}
