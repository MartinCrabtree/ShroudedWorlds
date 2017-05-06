using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HearthClickHandler : MonoBehaviour {
	public bool hearthFirstTime = true;
	public bool messageFirstTime = true;
	public bool lanternLightFirstTime = true;

    private Inventory invWindow;
    private Inventory craftWindow;
    ItemDatabase database;

    private int itemSlotID;

    void Start()
    {
        database = GetComponent<ItemDatabase>();

        invWindow = GameObject.Find("InventoryPanel").GetComponent<Inventory>();
        craftWindow = GameObject.Find("CraftingGUI").GetComponent<Inventory>();
    }

	// MARTIN TO UPDATE THIS
	void OnMouseDown(){
		


		
		if (hearthFirstTime == true) {
			Save.setGlobalMessage ("I might be able to use this to stay warm.");
			hearthFirstTime = false;
            LightLantern();
		}
        else
        {
			if(invWindow.CheckByID(16) && Save.currentIceLevel > 0){
                GetItemSlotID(16);

				if(messageFirstTime == true){
                    

					Save.setTopGlobalMessageLong ("Burning books is so 1930. Even though it feels wrong, it will keep me warm.");
                    invWindow.UseStackedItem(itemSlotID);
					messageFirstTime = false;
				}else{
					Save.setTopGlobalMessage ("You feed a book to the hearth and feel warmer.");
                    
                    invWindow.UseStackedItem(itemSlotID);
                }
				//remove the item from inventory
				LightingScript.lightHearth(true);
				EnvironmentalDamage.iceLevelCountdownCheck = true;
				Save.hearthAdded = true;
                Save.currentIceLevel = 0;

			// Tried to feed the hearth, but not needed
			}else if (invWindow.CheckByID(16) && Save.currentIceLevel <= 0){
				Save.setGlobalMessage ("It's already warm in here.. there is no need to feed the hearth.");	
			// Don't have a book in inventory
			}else{
				Save.setGlobalMessage ("I don't have what is needed to feed the hearth.");	
			}
            // HANDLE LIGHTING THE LANTERN, IF IT IS IN INVENTORY
            LightLantern();

		}
		
	}

    void OnTriggerEnter(Collider other)
    {

        invWindow.inHearthRange = true;
        //Debug.Log("hearth range set to true");

    }

    void OnTriggerExit(Collider other)
    {
        invWindow.inHearthRange = false;
        //Debug.Log("hearth range set to false");
    }

    private void GetItemSlotID(int itemID)
    {


        for (int i = 0; i < invWindow.items.Count; i++)
        {
            if(itemID == invWindow.items[i].ID)
            {
                itemSlotID = i;

            }
            
        }
        
    }

    private void LightLantern()
    {
        if (invWindow.CheckByID(17) && lanternLightFirstTime == true)
        {
			Save.setGlobalMessage ("I lit the lantern at the hearth.");	
            GetItemSlotID(17);
            invWindow.RemoveItem(itemSlotID);
            invWindow.AddItem(6);
            LightingScript.lightPlayer(true);
            lanternLightFirstTime = false;
        }
    }



}
