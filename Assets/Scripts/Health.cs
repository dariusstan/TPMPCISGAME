using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    [SerializeField] private QuizGameUI quizGameUI;
    //[SerializeField] public Text timerUI;
    // [SerializeField] private Response response;
    public float currentHealth { get; private set; }

    private void Awake()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            //player hurt
        }
        else
        {
            //player dead
            quizGameUI.GameOverPanel.SetActive(true);
            //countDownTimer.stop();
            //timerUI.text = "Game Ended!";
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            TakeDamage(1);
        // if (selectedOption != CorrectAns)
	    //      TakeDamage(1);
    }

    /// <summary>
    /// Method called to check the answer is correct or not
    /// </summary>
    /// <param name="selectedOption">answer string</param>
    /// <returns></returns>

}
