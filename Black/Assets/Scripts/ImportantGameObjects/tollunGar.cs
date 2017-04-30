using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tollunGar : MonoBehaviour {
	public bool firstTime = true;
	public GameObject exitTeleporter;


	void Awake(){
		exitTeleporter = GameObject.Find ("/Canvas/exitTeleporter");
	}
	void Start(){
		exitTeleporter.SetActive (false);
	}
	void OnMouseDown(){
		if (firstTime == true) {
			Save.setTopGlobalMessageLong ("Being forgotten is more than this wretch deserved. Still… what a way to die. I suppose everyone gets their Karmic reward, one way or another.");
			Journal.openJournal ();
			firstTime = false;
			StartCoroutine (coroutineOne (5));
		}
	}
	public IEnumerator coroutineOne(float seconds){
		yield return new WaitForSeconds(seconds);
		exitTeleporter.SetActive (true);
	}
}
