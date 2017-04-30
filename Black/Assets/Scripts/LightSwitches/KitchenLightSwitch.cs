using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenLightSwitch : MonoBehaviour {
	public bool lightsOff = true;

	void OnMouseDown(){
		if (lightsOff == true) {
			lightsOff = false;
			LightingScript.lightRoom ("Kitchen");
		} else {
			lightsOff = true;
			LightingScript.unLightRoom ("Kitchen");
		}
	}
}
