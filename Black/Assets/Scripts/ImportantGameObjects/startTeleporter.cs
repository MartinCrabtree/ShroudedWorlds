using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startTeleporter : MonoBehaviour {
	public bool startTeleporterFirstTime = true;

	void OnMouseDown(){
		if(startTeleporterFirstTime == true){
			Save.setGlobalMessage ("Damnation! Why did it have to be a one-way teleporter?!");
			startTeleporterFirstTime = false;
		}
	}
}
