using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kitchen : MonoBehaviour {

	void OnMouseDown(){
		DoorScript.unlockDoor ("kitchenDoor");
	}
}
