using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

	public GameObject diningRoomDoorOpened;
	public GameObject kitchenDoorOpened;
	public GameObject hallwayBDoorOpened;
	public GameObject guestBedroomDoorOpened;
	public GameObject masterBedroomDoorOpened;
	public GameObject studyDoorOpened;

	public GameObject diningRoomDoorLocked;
	public GameObject kitchenDoorLocked;
	public GameObject hallwayBDoorLocked;
	public GameObject guestBedroomDoorLocked;
	public GameObject masterBedroomDoorLocked;
	public GameObject studyDoorLocked;

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
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void openDoor(string doorName){
		if (doorName == "diningRoomDoor"){
			
		}else if (doorName == "kitchenDoor"){
			
		}else if (doorName == "hallwayBDoor"){
		}else if (doorName == "guestBedroomDoor"){
		}else if (doorName == "masterBedroomDoor"){
		}else if (doorName == "studyDoor"){
		}
	}

}
