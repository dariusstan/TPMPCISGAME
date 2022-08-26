using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class onclickpause : MonoBehaviour {
	public Button yourButton;
	[SerializeField] QuizGameUI quizGameUI;

	void Start () {
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		quizGameUI.PauseMenu.SetActive(true);
		Time.timeScale = 0f;
	}
}