using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statueClickHandler : MonoBehaviour {
	public bool removedMushroom = false;
	public GameObject lavaMushroom;

	void Awake(){
		lavaMushroom = GameObject.Find ("/Canvas/INVENTORYOBJECTS/Lens");
	}

	void OnMouseDown(){
		// MARTIN UPDATE THIS
		/*
		if (&& removedMushroom == false) {
			//then put the lava mushroom in inventory

			//removes the mushroom from the map
			lavaMushroom.gameObject.SetActive (false);
			removedMushroom = true;
		} else{
			Save.setTopGlobalMessageLong("I do not have the means to remove that glowing object.. It's far too hot");
		}
		*/
	}
}
