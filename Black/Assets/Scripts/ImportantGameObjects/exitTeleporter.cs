using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class exitTeleporter : MonoBehaviour {
	public bool firstTime = true;
	
	void OnMouseDown(){
		//SceneManager.LoadScene ("EndScene", LoadSceneMode.Single);
		//Initiate countdown
		if(firstTime == true){
			StartCoroutine(coroutineOne());	
			firstTime = false;
		}
	}
	public IEnumerator coroutineOne(){
		/*
		Save.setTopGlobalMessage ("15");
		yield return new WaitForSeconds (1);
		Save.setTopGlobalMessage ("14");
		yield return new WaitForSeconds (1);
		Save.setTopGlobalMessage ("13");
		yield return new WaitForSeconds (1);
		Save.setTopGlobalMessage ("12");
		yield return new WaitForSeconds (1);
		Save.setTopGlobalMessage ("11");
		yield return new WaitForSeconds (1);
		*/
		Save.setTopGlobalMessage ("10");
		yield return new WaitForSeconds (1);
		Save.setTopGlobalMessage ("9");
		yield return new WaitForSeconds (1);
		Save.setTopGlobalMessage ("8");
		yield return new WaitForSeconds (1);
		Save.setTopGlobalMessage ("7");
		yield return new WaitForSeconds (1);
		Save.setTopGlobalMessage ("6");
		yield return new WaitForSeconds (1);
		Save.setTopGlobalMessage ("5");
		yield return new WaitForSeconds (1);
		Save.setTopGlobalMessage ("4");
		yield return new WaitForSeconds (1);
		Save.setTopGlobalMessage ("3");
		yield return new WaitForSeconds (1);
		Save.setTopGlobalMessage ("2");
		yield return new WaitForSeconds (1);
		Save.setTopGlobalMessage ("1");
		yield return new WaitForSeconds (1);
		Save.setTopGlobalMessage ("0");
		yield return new WaitForSeconds (1);
		Save.setTopGlobalMessage ("");
		//Play animation on character
		Save.playerTeleporterAnimation.SetActive(true);
		Save.teleportSound = true;
		yield return new WaitForSeconds (2);
		//Enable black screen
		Save.endingBlackscreen.gameObject.SetActive (true);
		yield return new WaitForSeconds (2);
		//Play ending message
		Save.setGlobalMessage("Wait.. what?! .. WHERE AM I??");
		yield return new WaitForSeconds (5);
		Save.setGlobalMessage("TO BE CONTINUED...");
		yield return new WaitForSeconds (6);
		SceneManager.LoadScene("EndScene", LoadSceneMode.Single);
	}
}
