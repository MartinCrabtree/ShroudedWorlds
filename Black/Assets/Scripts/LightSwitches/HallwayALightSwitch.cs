using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwayALightSwitch : MonoBehaviour {
	public bool lightsOff = true;

	void OnMouseDown(){
		if (lightsOff == true) {
			lightsOff = false;
			LightingScript.lightRoom ("HallwayA");
		} else {
			lightsOff = true;
			LightingScript.unLightRoom ("HallwayA");
		}
	}
}
