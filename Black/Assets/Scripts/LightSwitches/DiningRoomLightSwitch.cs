using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiningRoomLightSwitch : MonoBehaviour {
	public bool lightsOff = true;

	void OnMouseDown(){
		if (lightsOff == true) {
			lightsOff = false;
			LightingScript.lightRoom ("DiningRoom");
		} else {
			lightsOff = true;
			LightingScript.unLightRoom ("DiningRoom");
		}
	}
}
