using System.Collections;
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
		diningRoomDoorOpened = GameObject.Find ("/Doors/diningRoomDoor/Opened");
		//kitchenDoorOpened = GameObject.Find ("/Canvas/Doors/kitchenDoor/Opened");
		kitchenDoorOpened = GameObject.Find ("/Doors/kitchenDoor/Opened");
		hallwayBDoorOpened = GameObject.Find ("/Doors/hallwayBDoor/Opened");
		guestBedroomDoorOpened = GameObject.Find ("/Doors/guestBedroomDoor/Opened");
		masterBedroomDoorOpened = GameObject.Find ("/Doors/masterBedroomDoor/Opened");
		studyDoorOpened = GameObject.Find ("/Doors/studyDoor/Opened");

		diningRoomDoorLocked = GameObject.Find ("/Doors/diningRoomDoor/Closed");
		kitchenDoorLocked = GameObject.Find ("/Doors/kitchenDoor/Closed");
		hallwayBDoorLocked = GameObject.Find ("/Doors/hallwayBDoor/Closed");
		guestBedroomDoorLocked = GameObject.Find ("/Doors/guestBedroomDoor/Closed");
		masterBedroomDoorLocked = GameObject.Find ("/Doors/masterBedroomDoor/Closed");
		studyDoorLocked = GameObject.Find ("/Doors/studyDoor/Closed");
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
			Debug.Log ("opening dining room door");
			Save.setGlobalMessage ("You unlocked the door.");
			diningRoomDoorLocked.gameObject.SetActive (false);
			diningRoomDoorOpened.gameObject.SetActive (true);
		}else if (doorName == "kitchenDoor"){
			Debug.Log ("opening kitchen door");
			Save.setGlobalMessage ("You unlocked the door.");
			kitchenDoorLocked.gameObject.SetActive (false);
			kitchenDoorOpened.gameObject.SetActive (true);
		}else if (doorName == "hallwayBDoor"){
			Debug.Log ("opening hallway B door");
			Save.setGlobalMessage ("You unlocked the door.");
			hallwayBDoorLocked.gameObject.SetActive (false);
			hallwayBDoorOpened.gameObject.SetActive (true);
		}else if (doorName == "guestBedroomDoor"){
			Debug.Log ("opening guest bedroom door");
			Save.setGlobalMessage ("You unlocked the door.");
			guestBedroomDoorLocked.gameObject.SetActive (false);
			guestBedroomDoorOpened.gameObject.SetActive (true);
		}else if (doorName == "masterBedroomDoor"){
			Debug.Log ("opening master bedroom door");
			Save.setGlobalMessage ("You unlocked the door.");
			masterBedroomDoorLocked.gameObject.SetActive (false);
			masterBedroomDoorOpened.gameObject.SetActive (true);
		}else if (doorName == "studyDoor"){
			Debug.Log ("opening study door");
			Save.setGlobalMessage ("You unlocked the door.");
			studyDoorLocked.gameObject.SetActive (false);
			studyDoorOpened.gameObject.SetActive (true);
		}
	}
	public static void unlockDoor(string doorName){
		if (doorName == "diningRoomDoor" && Save.diningRoomDoorOpen == false){
			Save.diningRoomDoorOpenSound = true;
			openDoor ("diningRoomDoor");
		}else if (doorName == "kitchenDoor" && Save.kitchenDoorOpen == false){
			Save.kitchenDoorOpenSound = true;
			openDoor ("kitchenDoor");
		}else if (doorName == "hallwayBDoor" && Save.hallwayBDoorOpen == false){
			Save.hallwayBDoorOpenSound = true;
			openDoor ("hallwayBDoor");
		}else if (doorName == "guestBedroomDoor" && Save.guestBedroomDoorOpen == false){
			Save.guestBedroomDoorOpenSound = true;
			openDoor ("guestBedroomDoor");
		}else if (doorName == "masterBedroomDoor" && Save.masterBedroomDoorOpen == false){
			Save.masterBedroomDoorOpenSound = true;
			openDoor ("masterBedroomDoor");
		}else if (doorName == "studyDoor" && Save.studyDoorOpen == false){
			Save.studyDoorOpenSound = true;
			openDoor ("studyDoor");
		}
	}
}
