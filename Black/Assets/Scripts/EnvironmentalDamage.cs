using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentalDamage : MonoBehaviour {

	// Ice Panel
	public GameObject icePanel;
	public GameObject iceLevelOne;
	public GameObject iceLevelTwo;
	public GameObject iceLevelThree;

	// Poison Panel
	public GameObject poisonPanel;
	public GameObject poisonLevelOne;
	public GameObject poisonLevelTwo;
	public GameObject poisonLevelThree;

	// Game over screen
	public GameObject gameover;

	// Poison Gas Room Panel
	public GameObject poisonGasPanel;

	// The Player
	public GameObject player;

	// Update control variables
	public bool iceLevelCountdown = true;
	public bool poisonLevelCountdown = true;

	//DELETE - this is temporary for update control variable for poisoning player
	public bool temp = true;

	void Awake(){
		player = GameObject.Find ("/player camera/player");

		gameover = GameObject.Find ("/Canvas/Gameover");

		icePanel = GameObject.Find ("/Canvas/icePanel");
		iceLevelOne = GameObject.Find ("/Canvas/icePanel/iceLevelOne");
		iceLevelTwo = GameObject.Find ("/Canvas/icePanel/iceLevelTwo");
		iceLevelThree = GameObject.Find ("/Canvas/icePanel/iceLevelThree");

		poisonPanel = GameObject.Find ("/Canvas/poisonPanel");
		poisonLevelOne = GameObject.Find ("/Canvas/poisonPanel/poisonLevelOne");
		poisonLevelTwo = GameObject.Find ("/Canvas/poisonPanel/poisonLevelTwo");
		poisonLevelThree = GameObject.Find ("/Canvas/poisonPanel/poisonLevelThree");

		poisonGasPanel = GameObject.Find ("/Canvas/Poison Gas");
	}
	// Use this for initialization
	void Start () {
		gameover.gameObject.SetActive (false);

		iceLevelOne.gameObject.SetActive (false);
		iceLevelTwo.gameObject.SetActive (false);
		iceLevelThree.gameObject.SetActive (false);
		poisonLevelOne.gameObject.SetActive (false);
		poisonLevelTwo.gameObject.SetActive (false);
		poisonLevelThree.gameObject.SetActive (false);

		poisonGasPanel.gameObject.SetActive (false);
		Debug.Log ("Ice Level Now: " + Save.currentIceLevel);
	}
	// Update is called once per frame
	void Update () {
		// ICE ENVIRONMENTAL CONTROLS
		// Increase ice level with time, if nothing added to hearth
		if(Save.currentIceLevel == 0 && iceLevelCountdown == true && Save.icetesting == true){
			iceLevelCountdown = false;
			StartCoroutine(iceLevelHandler());
		}
		if(Save.currentIceLevel == 1 && iceLevelCountdown == true){
			iceLevelCountdown = false;
			iceLevelOne.gameObject.SetActive (true);
			StartCoroutine(iceLevelHandler());
		}
		if(Save.currentIceLevel == 2 && iceLevelCountdown == true){
			iceLevelCountdown = false;
			iceLevelOne.gameObject.SetActive (false);
			iceLevelTwo.gameObject.SetActive (true);
			StartCoroutine(iceLevelHandler());
		}
		if (Save.currentIceLevel == 3 && iceLevelCountdown == true){
			iceLevelCountdown = false;
			iceLevelTwo.gameObject.SetActive (false);
			iceLevelThree.gameObject.SetActive (true);
			StartCoroutine(iceLevelHandler());
		}
		// When ice level is at highest, reduce movement speed
		if (Save.currentIceLevel > 3 && iceLevelCountdown == true){
			iceLevelCountdown = false;
			Debug.Log ("Adjusting player speed to 2");
			ARPGPlayerMoveNew.moveSpeed = 2;
		}
		// Reset ice level to 0, if something added to hearth
		if (Save.hearthAdded == true){
			Debug.Log ("Added item to hearth, restoring player speed");
			iceLevelOne.gameObject.SetActive (false);
			iceLevelTwo.gameObject.SetActive (false);
			iceLevelThree.gameObject.SetActive (false);
			Save.hearthAdded = false;
			Save.currentIceLevel = 0;
			ARPGPlayerMoveNew.moveSpeed = 6;
			Debug.Log ("Ice Level Now: " + Save.currentIceLevel);
		}

		// POISON ENVIRONMENTAL CONTROLS
		// Initiate poison gas - EDIT LATER, A TEMPORARY VARIABLE IS HERE, AND POISON GAS PANEL SHOULD NOT BE TRIGGERED LIKE THIS
		if (Save.poisonInitiate == true && poisonLevelCountdown == true && temp == true){
			Debug.Log ("Poison Gas Room Initiated");
			poisonGasPanel.gameObject.SetActive (true);
			//TEMP
			temp = false;
		}
		// If poisoned, increase poison level with time, if not poisonimmune
		if (Save.poisonImmune == false && Save.currentPoisonLevel == 0 && Save.poisonInitiate == true && poisonLevelCountdown == true){
			poisonLevelCountdown = false;
			StartCoroutine(poisonLevelHandler());
		}
		if (Save.poisonImmune == false && Save.currentPoisonLevel == 1 && Save.poisonInitiate == true && poisonLevelCountdown == true){
			poisonLevelCountdown = false;
			poisonLevelOne.gameObject.SetActive (true);
			StartCoroutine(poisonLevelHandler());
		}
		if (Save.poisonImmune == false && Save.currentPoisonLevel == 2 && Save.poisonInitiate == true && poisonLevelCountdown == true){
			poisonLevelCountdown = false;
			poisonLevelOne.gameObject.SetActive (false);
			poisonLevelTwo.gameObject.SetActive (true);
			StartCoroutine(poisonLevelHandler());
		}
		if (Save.poisonImmune == false && Save.currentPoisonLevel == 3 && Save.poisonInitiate == true && poisonLevelCountdown == true){
			poisonLevelCountdown = false;
			poisonLevelTwo.gameObject.SetActive (false);
			poisonLevelThree.gameObject.SetActive (true);
			StartCoroutine(poisonLevelHandler());
		}
		// Poison level maxed, game over!
		if (Save.poisonImmune == false && Save.currentPoisonLevel>3 && Save.poisonInitiate == true && poisonLevelCountdown == true){
			Debug.Log ("Poison Level maxed, Game over!");
			gameover.gameObject.SetActive (true);
			Save.gameOver = true;
			poisonLevelCountdown = false;
		}
		// Became poison immune, remove poison screen
		if (Save.poisonImmune == true && poisonLevelCountdown == false){
			poisonLevelOne.gameObject.SetActive (false);
			poisonLevelTwo.gameObject.SetActive (false);
			poisonLevelThree.gameObject.SetActive (false);
			poisonLevelCountdown = true;
			Save.poisonInitiate = false;
		}
	}
	// Helper Functions
	// Increase ice level with time, if nothing added to hearth
	public IEnumerator iceLevelHandler(){
		Debug.Log ("initiating ice handler countdown");
		yield return new WaitForSeconds(10);
		increaseIceLevel ();
		iceLevelCountdown = true;
	}
	// Increase poison level with time, if not poison immune
	public IEnumerator poisonLevelHandler(){
		Debug.Log ("initiating poison handler countdown");
		yield return new WaitForSeconds(10);
		increasePoisonLevel ();
		poisonLevelCountdown = true;
	}
	public void increaseIceLevel(){
		Save.currentIceLevel += 1;
		Debug.Log ("Ice Level Now: " + Save.currentIceLevel);
	}
	public void increasePoisonLevel(){
		Save.currentPoisonLevel += 1;
		Debug.Log ("Poison Level Now: " + Save.currentPoisonLevel);
	}
}
