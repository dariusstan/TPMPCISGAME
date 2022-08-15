
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] private DialogueUI dialogueUI;
    public IInteractable Interactable { get; set; }
    public DialogueUI DialogueUI => dialogueUI;


   private const float MoveSpeed = 10f;

   private Rigidbody2D rb;

   private AudioSource audioSrc;

   private void Start()
   {
    rb = GetComponent<Rigidbody2D>();
    audioSrc = GetComponent<AudioSource>();
   }

   private void Update()
   {
    if (dialogueUI.IsOpen) return;
    
    Vector2 input = new Vector2 ( Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    rb.MovePosition(rb.position + input.normalized * (MoveSpeed * Time.fixedDeltaTime));


    if (Input.GetKeyDown(KeyCode.Space))
    {
        Interactable?.Interact(this);
        SFX_manager.PlaySound ("Pickupsound_1");
    }
    if (rb.velocity.x !=0)
    {
        if (!audioSrc.isPlaying)
        {
            audioSrc.Play();
        }
    }
    else{
        audioSrc.Stop();
    }
   }
}
