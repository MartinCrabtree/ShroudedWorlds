using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwayB : MonoBehaviour {

	void OnMouseDown(){
		DoorScript.unlockDoor ("hallwayBDoor");
	}
}
