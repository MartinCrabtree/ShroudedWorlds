using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterBedroom : MonoBehaviour {

	void OnMouseDown(){
		DoorScript.unlockDoor ("masterBedroomDoor");
	}
}
