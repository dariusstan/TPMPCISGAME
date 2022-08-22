using UnityEngine;

[System.Serializable]
public class Response
{
   [SerializeField] private string responseText;
   [SerializeField] private DialogueObject dialogueObject;
<<<<<<< HEAD
   //[SerializeField] public string correctAns;
=======
>>>>>>> 32028824b07c7e5c0b75a4b50e8f88bb25858d84

   public string ResponseText => responseText;

   public DialogueObject DialogueObject => dialogueObject;

}
