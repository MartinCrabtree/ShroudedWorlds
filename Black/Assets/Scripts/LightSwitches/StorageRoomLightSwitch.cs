using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageRoomLightSwitch : MonoBehaviour {
	public bool lightsOff = true;

	void OnMouseDown(){
		if (lightsOff == true) {
			lightsOff = false;
			LightingScript.lightRoom ("StorageRoom");
		} else {
			lightsOff = true;
			LightingScript.unLightRoom ("StorageRoom");
		}
	}
}
