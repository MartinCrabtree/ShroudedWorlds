using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingHandler : MonoBehaviour {

    private int itemID;
    private ItemDatabase database;
    //private ItemData itemData;
    

    public Inventory invWindow;
    private Inventory craftWindow;

    // holds item ID for each crafting slot
    private int[] craftSlotID;
    




    void Start () {
        database = GetComponent<ItemDatabase>();

        invWindow = GameObject.Find("InventoryPanel").GetComponent<Inventory>();
        craftWindow = GameObject.Find("CraftingGUI").GetComponent<Inventory>();

        craftSlotID = new int[3];

        // for testing
        //invWindow.AddItem(4);

        // lit lantern  = candle + unlit lantern (at hearth)
        // poison invuln = flask + herb
        // key to study = blank scroll + silver key + lava mushroom
        // lava mushroom = tong + tenderizer @ statue



        AddToCraftingWindow(1);
        AddToCraftingWindow(2);

        //CraftingCheck();


    }

    public void CraftingCheck()
    {
        // grab IDs for each crafting slot
        for (int i = 0; i < 3; i++)
        {
            craftSlotID[i] = craftWindow.items[i].ID;
            
                        
        }

        // craft a poison immune potion ID 1 & 2
        for(int i = 0; i < 3; i++)
        {
            if(craftSlotID[i] == 1)
            {
                if(craftSlotID[0] == 2 || craftSlotID[1] == 2 || craftSlotID[2] == 2)
                {
                    Save.setGlobalMessageLong("You craft a potion of poison immunity. After you quaff it, you no longer feel the effects of poison.");
                    Save.poisonImmune = true;
                    ClearCraftingSlots();
                }
            }
            break;
        }

        // craft lit lantern

        



    }

    public void CraftItem(int itemID)
    {
        invWindow.AddItem(itemID);
    }

    public void AddToCraftingWindow(int itemID)
    {
        craftWindow.AddItem(itemID);
    }

    // set all slots in crafting window to null
    public void ClearCraftingSlots()
    {

        craftWindow.ResetItemList();
        /*
        for (int i = 0; i < 3; i++)
        {
            
            craftWindow.items[i] = ItemV2();
            
            

        }

        for (int i = 0; i < 3; i++)
        {
            Debug.Log("craft item ID " + craftWindow.items[i].ID);

        }

        return;

    */
        
    }
	
	

}
