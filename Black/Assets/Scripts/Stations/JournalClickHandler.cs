using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JournalClickHandler : MonoBehaviour {
	public bool journalFirstTime = true;

	void OnMouseDown(){
		if(journalFirstTime == true){
			Save.setTopGlobalMessageLong ("Ah! A journal! I wonder whose it could be... Hmm. There are pages missing.");
			journalFirstTime = false;
		}
		Journal.openJournal ();
	}
}
