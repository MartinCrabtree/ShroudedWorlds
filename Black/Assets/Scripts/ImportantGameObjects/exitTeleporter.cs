using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class exitTeleporter : MonoBehaviour {
	
	void OnMouseDown(){
		SceneManager.LoadScene ("EndScene", LoadSceneMode.Single);
	}
}
