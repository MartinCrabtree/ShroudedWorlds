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

	void Awake(){
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
		
	}
	// Update is called once per frame
	void Update () {
		
	}
	public void increaseIceLevel(){}
	public void decreaseIceLevel(){}
	public void increasePoisonLevel(){}
	public void decreasePoisonLevel(){}
}
