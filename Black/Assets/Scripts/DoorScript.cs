﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

	public static GameObject diningRoomDoorOpened;
	public static GameObject kitchenDoorOpened;
	public static GameObject hallwayBDoorOpened;
	public static GameObject guestBedroomDoorOpened;
	public static GameObject masterBedroomDoorOpened;
	public static GameObject studyDoorOpened;

	public static GameObject diningRoomDoorLocked;
	public static GameObject kitchenDoorLocked;
	public static GameObject hallwayBDoorLocked;
	public static GameObject guestBedroomDoorLocked;
	public static GameObject masterBedroomDoorLocked;
	public static GameObject studyDoorLocked;

	void Awake (){
		diningRoomDoorOpened = GameObject.Find ("/Canvas/Doors/diningRoomDoor/Opened");
		kitchenDoorOpened = GameObject.Find ("/Canvas/Doors/kitchenDoor/Opened");
		hallwayBDoorOpened = GameObject.Find ("/Canvas/Doors/hallwayBDoor/Opened");
		guestBedroomDoorOpened = GameObject.Find ("/Canvas/Doors/guestBedroomDoor/Opened");
		masterBedroomDoorOpened = GameObject.Find ("/Canvas/Doors/masterBedroomDoor/Opened");
		studyDoorOpened = GameObject.Find ("/Canvas/Doors/studyDoor/Opened");

		diningRoomDoorLocked = GameObject.Find ("/Canvas/Doors/diningRoomDoor/Closed");
		kitchenDoorLocked = GameObject.Find ("/Canvas/Doors/kitchenDoor/Closed");
		hallwayBDoorLocked = GameObject.Find ("/Canvas/Doors/hallwayBDoor/Closed");
		guestBedroomDoorLocked = GameObject.Find ("/Canvas/Doors/guestBedroomDoor/Closed");
		masterBedroomDoorLocked = GameObject.Find ("/Canvas/Doors/masterBedroomDoor/Closed");
		studyDoorLocked = GameObject.Find ("/Canvas/Doors/studyDoor/Closed");
	}
	// Use this for initialization
	void Start () {
		diningRoomDoorOpened.gameObject.SetActive (false);
		kitchenDoorOpened.gameObject.SetActive (false);
		hallwayBDoorOpened.gameObject.SetActive (false);
		guestBedroomDoorOpened.gameObject.SetActive (false);
		masterBedroomDoorOpened.gameObject.SetActive (false);
		studyDoorOpened.gameObject.SetActive (false);
	}
	public static void openDoor(string doorName){
		if (doorName == "diningRoomDoor"){
			diningRoomDoorLocked.gameObject.SetActive (false);
			diningRoomDoorOpened.gameObject.SetActive (true);
		}else if (doorName == "kitchenDoor"){
			kitchenDoorLocked.gameObject.SetActive (false);
			kitchenDoorOpened.gameObject.SetActive (true);
		}else if (doorName == "hallwayBDoor"){
			hallwayBDoorLocked.gameObject.SetActive (false);
			hallwayBDoorOpened.gameObject.SetActive (true);
		}else if (doorName == "guestBedroomDoor"){
			guestBedroomDoorLocked.gameObject.SetActive (false);
			guestBedroomDoorOpened.gameObject.SetActive (true);
		}else if (doorName == "masterBedroomDoor"){
			masterBedroomDoorLocked.gameObject.SetActive (false);
			masterBedroomDoorOpened.gameObject.SetActive (true);
		}else if (doorName == "studyDoor"){
			studyDoorLocked.gameObject.SetActive (false);
			studyDoorOpened.gameObject.SetActive (true);
		}
	}
	public static void unlockDoor(string doorName){
		if (doorName == "diningRoomDoor" && Save.diningRoomDoorOpen == true){
			openDoor ("diningRoomDoor");
		}else if (doorName == "kitchenDoor" && Save.kitchenDoorOpen == true){
			openDoor ("kitchenDoor");
		}else if (doorName == "hallwayBDoor" && Save.hallwayBDoorOpen == true){
			openDoor ("hallwayBDoor");
		}else if (doorName == "guestBedroomDoor" && Save.guestBedroomDoorOpen == true){
			openDoor ("guestBedroomDoor");
		}else if (doorName == "masterBedroomDoor" && Save.masterBedroomDoorOpen == true){
			openDoor ("masterBedroomDoor");
		}else if (doorName == "studyDoor" && Save.studyDoorOpen == true){
			openDoor ("studyDoor");
		}
	}
}