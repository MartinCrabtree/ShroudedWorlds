using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenuButton : MonoBehaviour {
	private Button startButton;

	void Start () {
		startButton = GameObject.Find ("/Canvas/Button").GetComponent<Button> ();
		startButton.onClick.AddListener (() => OnClickStartButton ());
	}
	public void OnClickStartButton(){
		SceneManager.LoadScene("Gracemodifiedagain", LoadSceneMode.Single);
	}
}
