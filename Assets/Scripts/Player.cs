
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] private DialogueUI dialogueUI;
    public IInteractable Interactable { get; set; }
    public DialogueUI DialogueUI => dialogueUI;
    public int maxHealth = 3;
    public int currentHealth;
    public HealthBar healthBar;
    public GameObject GameOverScreen;

   private const float MoveSpeed = 10f;

   private Rigidbody2D rb;

   private AudioSource audioSrc;
   public bool isMove = false;
   [SerializeField] private AudioSource interactsound;

   private void Start()
   {
    rb = GetComponent<Rigidbody2D>();
    audioSrc = GetComponent<AudioSource>();
    currentHealth=maxHealth;
    healthBar.SetMaxHealth(maxHealth);
   }

   private void Update()
   {
    if (dialogueUI.IsOpen) return;
    
    Vector2 input = new Vector2 ( Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    rb.MovePosition(rb.position + input.normalized * (MoveSpeed * Time.fixedDeltaTime));

    if (Input.GetKeyDown(KeyCode.Space))
    {
        Interactable?.Interact(this);
        interactsound.Play();
    }
    if ( input.x != 0 || input.y !=0 )
            isMove = true;
        else
            isMove = false;

        if (isMove){
            if (!audioSrc.isPlaying)
            audioSrc.Play ();
        }
        else
            audioSrc.Stop();
   }


    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        if (currentHealth == 0){
            GameOverScreen.SetActive(true);
        }
    }
}
