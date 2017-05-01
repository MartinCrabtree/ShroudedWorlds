using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study : MonoBehaviour {
	public bool firstTime = true;
    private Inventory invWindow;
    private ItemDatabase database;

    void Start()
    {
        database = GetComponent<ItemDatabase>();

        invWindow = GameObject.Find("InventoryPanel").GetComponent<Inventory>();
        
    }

    void OnMouseDown(){
		
		if(invWindow.CheckByID(15))
        {
			DoorScript.unlockDoor ("studyDoor");	
		}else{
            Save.poisonGasAnimationStart = true;
            if (firstTime == true){
				Save.setTopGlobalMessageLong("I do not have the means to unlock this door.");
				
				firstTime = false;
			}
			Save.setTopGlobalMessageLong("I do not have the means to unlock this door.");
		}
		
	}
}
