using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HearthClickHandler : MonoBehaviour {
	public bool hearthFirstTime = true;

	// MARTIN TO UPDATE THIS - Martin you will need to call some static script from your Hearth script.
	void OnMouseDown(){
		// First use of hearth, have this message pop up
		if(hearthFirstTime == true){
			Save.setGlobalMessage ("I might be able to use this to stay warm.");
			hearthFirstTime = false;
		}
	}
}
