using UnityEngine;
// using System.Collections;
// using System.Collections.Generic;

[CreateAssetMenu(menuName = "Dialogue/DialogueObject")]
public class DialogueObject : ScriptableObject
{
   [SerializeField] [TextArea] private string[] dialogue;
   [SerializeField] private Response[] responses;
   //[SerializeField] private List<DialogueObject> options;

   public string[] Dialogue =>  dialogue;

   public bool HasResponses => Responses != null && Responses.Length > 0;
   public Response[] Responses => responses;
}
