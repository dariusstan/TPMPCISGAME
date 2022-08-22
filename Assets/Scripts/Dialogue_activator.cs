
using UnityEngine;

public class Dialogue_activator : MonoBehaviour, IInteractable
{

    [SerializeField] private DialogueObject dialogueObject;
    public bool isExclamation;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && other.TryGetComponent(out Player player))
        {
            player.Interactable = this;
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && other.TryGetComponent(out Player player))
        {
           if (player.Interactable is Dialogue_activator dialogue_Activator && dialogue_Activator == this)
           {
            player.Interactable = null;
           }
        }
    }


   public void Interact(Player player)
   {
    player.DialogueUI.ShowDialogue(dialogueObject);
    if (isExclamation){
        Destroy(gameObject);
    }
   }

}
