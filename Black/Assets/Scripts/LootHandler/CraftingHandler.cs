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

        
        // invWindow.AddItem(7);
        // invWindow.AddItem(5);





    }

    public void CraftingCheck()
    {

        // lit lantern  = candle + unlit lantern (at hearth)
        // poison invuln = flask + herb
        // key to study = blank scroll + silver key + lava mushroom
        // lava mushroom = tong + tenderizer @ statue


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
                    Save.setGlobalMessage("You craft a potion of poison immunity. After you quaff it, you no longer feel the effects of poison.");
                    Save.poisonImmune = true;
                    ClearCraftingSlots();
                }
            }
            
        }

        // craft lantern with candle (candle + empty lantern)
        for (int i = 0; i < 3; i++)
        {
            if (craftSlotID[i] == 7)  // check for candle
            {
                if (craftSlotID[0] == 5 || craftSlotID[1] == 5 || craftSlotID[2] == 5) // check for lantern unlit
                {
                    // need additional check for hearth proximity
                    CraftItem(17);
                    Save.setGlobalMessage("You have crafted a lantern with a candle inside.");
                    ClearCraftingSlots();
                }
            }
            
        }

        // key to study = blank scroll + silver key + lava mushroom
        for (int i = 0; i < 3; i++)
        {
            if (craftSlotID[i] == 13)  // blank scroll
            {
                if (craftSlotID[0] == 0 || craftSlotID[1] == 0 || craftSlotID[2] == 0) // silver key
                {
                    if (craftSlotID[0] == 14 || craftSlotID[1] == 14 || craftSlotID[2] == 14) // lava mushroom
                    {
                        CraftItem(15); // craft key to the study
                        Save.setGlobalMessage("You have crafted a key to the study.");
                        ClearCraftingSlots();
                    }
                }
            }
            
        }

        // lava mushroom = tong + tenderizer @ statue
        for (int i = 0; i < 3; i++)
        {
            if (craftSlotID[i] == 9)  // check for tenderizer
            {
                if (craftSlotID[0] == 11 || craftSlotID[1] == 11 || craftSlotID[2] == 11) // tongs
                {
                    // need additional check for statue proximity
                    CraftItem(14); // craft lava mushroom
                    ClearCraftingSlots();
                }
            }

        }


    }



    //
    //
    public void CraftItem(int itemID)
    {
        invWindow.AddItem(itemID);
    }

    //
    //
    public void AddToCraftingWindow(int itemID)
    {
        craftWindow.AddItem(itemID);
    }

    //
    // set all slots in crafting window to null
    public void ClearCraftingSlots()
    {

        craftWindow.ResetItemList();
        
        
    }
	
	

}
