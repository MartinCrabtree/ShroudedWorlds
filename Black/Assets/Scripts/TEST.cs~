using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TEST : MonoBehaviour {
	public Button poisonstart;
	public Button poisonimmune;
	public Button feedhearth;
	public Button diningRoom;
	public Button kitchen;
	public Button rempoisonimmune;
	public Button hallwayB;
	public Button guestBedroom;
	public Button masterBedroom;
	public Button study;
	public Button lightHallwayA;
	public Button lightStorageRoom;
	public Button lightDiningRoom;
	public Button lightKitchen;
	public Button lightStartingRoom;

	void Awake (){
		poisonstart = GameObject.Find ("/Canvas/TemporaryTestingButtons/poisonstart").GetComponent<Button>();
		poisonimmune = GameObject.Find ("/Canvas/TemporaryTestingButtons/poisonimmune").GetComponent<Button>();
		feedhearth = GameObject.Find ("/Canvas/TemporaryTestingButtons/feedhearth").GetComponent<Button>();
		diningRoom = GameObject.Find ("/Canvas/TemporaryTestingButtons/diningRoom").GetComponent<Button>();
		kitchen = GameObject.Find ("/Canvas/TemporaryTestingButtons/kitchen").GetComponent<Button>();
		rempoisonimmune = GameObject.Find ("/Canvas/TemporaryTestingButtons/rempoisonimmune").GetComponent<Button>();
		hallwayB = GameObject.Find ("/Canvas/TemporaryTestingButtons/hallwayB").GetComponent<Button>();
		guestBedroom = GameObject.Find ("/Canvas/TemporaryTestingButtons/guestBedroom").GetComponent<Button>();
		masterBedroom = GameObject.Find ("/Canvas/TemporaryTestingButtons/masterBedroom").GetComponent<Button>();
		study = GameObject.Find ("/Canvas/TemporaryTestingButtons/study").GetComponent<Button>();
		lightHallwayA = GameObject.Find ("/Canvas/TemporaryTestingButtons/lightHallwayA").GetComponent<Button>();
		lightStorageRoom = GameObject.Find ("/Canvas/TemporaryTestingButtons/lightStorageRoom").GetComponent<Button>();
		lightDiningRoom = GameObject.Find ("/Canvas/TemporaryTestingButtons/lightDiningRoom").GetComponent<Button>();
		lightKitchen = GameObject.Find ("/Canvas/TemporaryTestingButtons/lightKitchen").GetComponent<Button>();
		lightStartingRoom = GameObject.Find ("/Canvas/TemporaryTestingButtons/lightStartingRoom").GetComponent<Button>();
	}
	// Use this for initialization
	void Start () {
		poisonstart.onClick.AddListener (poisonstart1);
		poisonimmune.onClick.AddListener (poisonimmune1);
		feedhearth.onClick.AddListener (feedhearth1);
		diningRoom.onClick.AddListener (diningRoom1);
		kitchen.onClick.AddListener (kitchen1);
		rempoisonimmune.onClick.AddListener (rempoisonimmune1);
		hallwayB.onClick.AddListener (hallwayB1);
		guestBedroom.onClick.AddListener (guestBedroom1);
		masterBedroom.onClick.AddListener (masterBedroom1);
		study.onClick.AddListener (study1);
		lightHallwayA.onClick.AddListener (lightHallwayA1);
		lightStorageRoom.onClick.AddListener (lightStorageRoom1);
		lightDiningRoom.onClick.AddListener (lightDiningRoom1);
		lightKitchen.onClick.AddListener (lightKitchen1);
		lightStartingRoom.onClick.AddListener (lightStartingRoom1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void poisonstart1(){
		Debug.Log ("pressed button");
		Save.poisonInitiate = true;
		Debug.Log ("Poisoning Player");
	}
	public void poisonimmune1(){
		Debug.Log ("pressed button");
		Save.poisonImmune = true;
	}
	public void feedhearth1(){
		Debug.Log ("pressed button");
		Save.hearthAdded = true;
	}
	public void diningRoom1(){
		Debug.Log ("pressed button");
		DoorScript.unlockDoor ("diningRoomDoor");
	}
	public void kitchen1(){
		Debug.Log ("pressed button");
		DoorScript.unlockDoor ("kitchenDoor");
	}
	public void rempoisonimmune1(){
		Debug.Log ("pressed button");
		Debug.Log ("starting ice effects");
		Save.icetesting = true;
	}
	public void hallwayB1(){
		Debug.Log ("pressed button");
		DoorScript.unlockDoor ("hallwayBDoor");
	}
	public void guestBedroom1(){
		Debug.Log ("pressed button");
		DoorScript.unlockDoor ("guestBedroomDoor");
	}
	public void masterBedroom1(){
		Debug.Log ("pressed button");
		DoorScript.unlockDoor ("masterBedroomDoor");
	}
	public void study1(){
		Debug.Log ("pressed button");
		DoorScript.unlockDoor ("studyDoor");
	}
	public void lightHallwayA1(){
		Debug.Log ("pressed button");
		LightingScript.lightRoom ("HallwayA");
	}
	public void lightStorageRoom1(){
		Debug.Log ("pressed button");
		LightingScript.lightRoom ("StorageRoom");
	}
	public void lightDiningRoom1(){
		Debug.Log ("pressed button");
		LightingScript.lightRoom ("DiningRoom");
	}
	public void lightKitchen1(){
		Debug.Log ("pressed button");
		LightingScript.lightRoom ("Kitchen");
	}
	public void lightStartingRoom1(){
		Debug.Log ("pressed button");
		LightingScript.lightRoom ("StartingRoom");
	}
}
