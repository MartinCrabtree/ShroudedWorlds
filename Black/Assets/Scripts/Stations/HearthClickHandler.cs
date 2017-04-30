using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HearthClickHandler : MonoBehaviour {
	public bool hearthFirstTime = true;

	void OnMouseDown(){
		// First use of hearth, have this message pop up
		if (hearthFirstTime == true) {
			Save.setGlobalMessageLong ("I might be able to use this to stay warm.");
			hearthFirstTime = false;
		} else {
			// MARTIN TO UPDATE THIS - check for oil soaked tome in if condition, then remove it from inventory in that same condition branch
			/*
			if(&& Save.CurrentIceLevel > 0){
				Save.setTopGlobalMessageLong ("Burning books is so 1930. Even though it feels wrong, it will keep me warm.");
				LightingScript.lightHearth(true);
				Save.hearthAdded = true;
			}else{
				Save.setGlobalMessageLong ("I don't have what is needed to feed the hearth.");
			}
			// HANDLE LIGHTING THE LANTERN, IF IT IS IN INVENTORY
			if(){
				LightingScript.lightPlayer (true);
			}
			*/
		}
	}
}
