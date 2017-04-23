using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Inventory : MonoBehaviour {

    GameObject inventoryPanel;
    GameObject slotPanel;
    public GameObject inventorySlot;
    public GameObject inventoryItem;
    ItemDatabase database;

    public int slotAmount = 16;

    
    public List<ItemV2> items = new List<ItemV2>();
    public List<GameObject> slots = new List<GameObject>();

    void Start()
    {
        database = GetComponent<ItemDatabase>();

        inventoryPanel = GameObject.Find("InventoryPanel");
        slotPanel = inventoryPanel.transform.FindChild("SlotPanel").gameObject;
        
        for(int i = 0; i < slotAmount; i++)
        {
            ////////// NEED TO FIX
            // items[i].Add(new ItemV2());
            
            slots.Add(Instantiate(inventorySlot));
            slots[i].transform.SetParent(slotPanel.transform);
            slots[i].GetComponent<ItemSlot>().slotID = i; // for Drag/Drop to get origial item location
        }


    }

    public void AddItem(int id)
    {
        ItemV2 itemToAdd = database.FetchItemByID(id);
        // find empty slot and add to inventory array and set parent
        for(int i = 0; i <items.Count; i++)
        {
            if(items[i].ID == -1)
            {
                items[i] = itemToAdd;
                GameObject itemObj = Instantiate(inventoryItem);
                itemObj.GetComponent<ItemData>().item = itemToAdd;
                itemObj.GetComponent<ItemData>().slotLocation = i;  // location data for Drag/Drop
                itemObj.transform.SetParent(slots[i].transform);
                itemObj.transform.position = Vector2.zero;
                itemObj.GetComponent<Image>().sprite = itemToAdd.Sprite;
                itemObj.name = itemToAdd.Title;
                
                break;
            }
        }
    }




}
