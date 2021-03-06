using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statueClickHandler : MonoBehaviour {
	public bool removedMushroom = false;
	public GameObject lavaMushroom;
    private Inventory invWindow;

    private int itemSlotID;


    void Awake(){
		lavaMushroom = GameObject.Find ("/Canvas/INVENTORYOBJECTS/Lens");
	}

    void Start()
    {
        invWindow = GameObject.Find("InventoryPanel").GetComponent<Inventory>();

        
    }

	void OnMouseDown(){
		
		if (invWindow.CheckByID(11) && invWindow.CheckByID(9) && removedMushroom == false) {
			Save.setGlobalMessageLong("You used the tong and the tenderizer and extracted the lava mushroom");
            invWindow.AddItem(14);

            invWindow.GetItemSlotID(11);
            itemSlotID = invWindow.itemSlotID;
            invWindow.RemoveItem(itemSlotID);

            invWindow.GetItemSlotID(9);
            itemSlotID = invWindow.itemSlotID;
            invWindow.RemoveItem(itemSlotID);

            //removes the mushroom from the map
            lavaMushroom.gameObject.SetActive (false);
			removedMushroom = true;
		} else{
			Save.setTopGlobalMessageLong("I do not have the means to remove that glowing object.. It's far too hot");
		}
		
	}
}
