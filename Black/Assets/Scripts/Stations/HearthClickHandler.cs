using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HearthClickHandler : MonoBehaviour {
	public bool hearthFirstTime = true;
	public bool messageFirstTime = true;
	public bool lanternLightFirstTime = true;

	// MARTIN TO UPDATE THIS
	void OnMouseDown(){
		// First use of hearth, have this message pop up

		/*
		if (hearthFirstTime == true) {
			Save.setGlobalMessageLong ("I might be able to use this to stay warm.");
			hearthFirstTime = false;
		} else {
			if(&& Save.CurrentIceLevel > 0){
				if(messageFirstTime == true){
					Save.setTopGlobalMessageLong ("Burning books is so 1930. Even though it feels wrong, it will keep me warm.");
					messageFirstTime = false;
				}else{
					Save.setTopGlobalMessageLong ("You feed a book to the hearth and feel warmer.");					
				}
				//remove the item from inventory
				LightingScript.lightHearth(true);
				Save.hearthAdded = true;
			// Tried to feed the hearth, but not needed
			}else if (&& Save.currentIceLevel !> 0){
				Save.setGlobalMessageLong ("It's already warm in here.. there is no need to feed the hearth.");	
			// Don't have a book in inventory
			}else{
				Save.setGlobalMessageLong ("I don't have what is needed to feed the hearth.");	
			}
			// HANDLE LIGHTING THE LANTERN, IF IT IS IN INVENTORY
			if(&& lanternLightFirstTime == true){
				LightingScript.lightPlayer (true);
				lanternLightFirstTime = false;
			}

		}
		*/
	}
}
