using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingSlots : MonoBehaviour {

    GameObject craftingGUI;
    GameObject craftingPanel;
    //GameObject inventoryPanel;
    //GameObject slotPanel;
    public GameObject inventorySlot;
    public GameObject inventoryItem;
    ItemDatabase database;
    Inventory inv;

    private int slotAmount = 3;
    

    public List<ItemV2> items = new List<ItemV2>();
    public List<GameObject> slots = new List<GameObject>();


    void Start()
    {
        Debug.Log("Starting crafting script");

        database = GetComponent<ItemDatabase>();
        inv = GameObject.Find("InventoryPanel").GetComponent<Inventory>();

        //inventoryPanel = GameObject.Find("InventoryPanel");
        //slotPanel = inventoryPanel.transform.FindChild("SlotPanel").gameObject;
        craftingGUI = GameObject.Find("CraftingGUI");
        craftingPanel = craftingGUI.transform.FindChild("CraftingPanel").gameObject;

        for (int i = 0; i < slotAmount; i++)
        {
            items.Add(new ItemV2());
            slots.Add(Instantiate(inventorySlot));
            slots[i].GetComponent<ItemSlot>().slotID = i; // set slotID for drag/drop in ItemSlot
            slots[i].transform.SetParent(craftingPanel.transform);  // allows to follow the grid layout
            
        }

        // testing
        CraftItem(10);



    }

    public void CraftItem(int itemID)
    {
        Debug.Log("Adding Item " + itemID);
        inv.AddItem(itemID);

    }


    


}
