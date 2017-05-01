using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwayB : MonoBehaviour {

    private Inventory invWindow;
    private ItemDatabase database;

    void Start()
    {
        database = GetComponent<ItemDatabase>();

        invWindow = GameObject.Find("InventoryPanel").GetComponent<Inventory>();

    }

    void OnMouseDown(){
		
		if(invWindow.CheckByID(4))
        {
			DoorScript.unlockDoor ("hallwayBDoor");	
		}else{
			Save.setTopGlobalMessageLong("I do not have the means to unlock this door.");
		}
		
	}
}
