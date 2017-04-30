using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRoomLightSwitch : MonoBehaviour {
	public bool lightsOff = true;

	void OnMouseDown(){
		if (lightsOff == true) {
			lightsOff = false;
			LightingScript.lightRoom ("StartingRoom");
		} else {
			lightsOff = true;
			LightingScript.unLightRoom ("StartingRoom");
		}
	}
}
