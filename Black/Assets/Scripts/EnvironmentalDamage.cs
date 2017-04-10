using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentalDamage : MonoBehaviour {

	public GameObject icePanel;
	public GameObject iceLevelOne;
	public GameObject iceLevelTwo;
	public GameObject iceLevelThree;

	public GameObject poisonPanel;
	public GameObject poisonLevelOne;
	public GameObject poisonLevelTwo;
	public GameObject poisonLevelThree;

	public GameObject poisonGasPanel;

	public GameObject player;

	void Awake(){
		player = GameObject.Find ("/player camera/player");

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
		iceLevelOne.gameObject.SetActive (false);
		iceLevelTwo.gameObject.SetActive (false);
		iceLevelThree.gameObject.SetActive (false);
		poisonLevelOne.gameObject.SetActive (false);
		poisonLevelTwo.gameObject.SetActive (false);
		poisonLevelThree.gameObject.SetActive (false);
	}
	// Update is called once per frame
	void Update () {
		// Increase ice level with time, if nothing added to hearth
		if(Save.currentIceLevel == 0){
			StartCoroutine(iceLevelHandler());
		}
		if(Save.currentIceLevel == 1){
			iceLevelOne.gameObject.SetActive (true);
			StartCoroutine(iceLevelHandler());
		}
		if(Save.currentIceLevel == 2){
			iceLevelOne.gameObject.SetActive (false);
			iceLevelTwo.gameObject.SetActive (true);
			StartCoroutine(iceLevelHandler());
		}
		if (Save.currentIceLevel == 3){
			iceLevelTwo.gameObject.SetActive (false);
			iceLevelThree.gameObject.SetActive (true);
			StartCoroutine(iceLevelHandler());
		}
		// When ice level is at highest, reduce movement speed
		if (Save.currentIceLevel > 3){
			ARPGPlayerMoveNew.moveSpeed = 2;
		}
		// Reset ice level to 0, if something added to hearth
		if (Save.hearthAdded == true){
			iceLevelThree.gameObject.SetActive (false);
			Save.currentIceLevel = 0;
			ARPGPlayerMoveNew.moveSpeed = 6;
		}
		// If poisoned, increase poison level with time, if not poisonimmune
		if (Save.poisonImmune == false && Save.currentPoisonLevel == 0 && Save.poisonInitiate == true){
			StartCoroutine(poisonLevelHandler());
		}
		if (Save.poisonImmune == false && Save.currentPoisonLevel == 1 && Save.poisonInitiate == true){
			poisonLevelOne.gameObject.SetActive (true);
			StartCoroutine(poisonLevelHandler());
		}
		if (Save.poisonImmune == false && Save.currentPoisonLevel == 2 && Save.poisonInitiate == true){
			poisonLevelOne.gameObject.SetActive (false);
			poisonLevelTwo.gameObject.SetActive (true);
			StartCoroutine(poisonLevelHandler());
		}
		if (Save.poisonImmune == false && Save.currentPoisonLevel == 3 && Save.poisonInitiate == true){
			poisonLevelTwo.gameObject.SetActive (false);
			poisonLevelThree.gameObject.SetActive (true);
			StartCoroutine(poisonLevelHandler());
		}
		// Poison level maxed, game over!
		if (Save.poisonImmune == false && Save.currentPoisonLevel>3 && Save.poisonInitiate == true){
			Save.gameOver = true;
		}
		// Became poison immune, remove poison screen
		if (Save.poisonImmune == true){
			poisonLevelThree.gameObject.SetActive (false);
		}
	}
	// Helper Functions
	public IEnumerator iceLevelHandler(){
		// Increase ice level with time, if nothing added to hearth
		yield return new WaitForSeconds(10);
		increaseIceLevel ();
	}
	public IEnumerator poisonLevelHandler(){
		// Increase ice level with time, if nothing added to hearth
		yield return new WaitForSeconds(10);
		increasePoisonLevel ();
	}
	public void increaseIceLevel(){
		Save.currentIceLevel += 1;
	}
	public void increasePoisonLevel(){
		Save.currentPoisonLevel += 1;
	}
}
