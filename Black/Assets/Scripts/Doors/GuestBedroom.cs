using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuestBedroom : MonoBehaviour {

	void OnMouseDown(){
		DoorScript.unlockDoor ("guestBedroomDoor");
	}
}
