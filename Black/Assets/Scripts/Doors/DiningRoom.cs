using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiningRoom : MonoBehaviour {

	void OnMouseDown(){
		DoorScript.unlockDoor ("diningRoomDoor");
	}
}
