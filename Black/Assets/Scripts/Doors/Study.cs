using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study : MonoBehaviour {

	void OnMouseDown(){
		DoorScript.unlockDoor ("studyDoor");
	}
}
