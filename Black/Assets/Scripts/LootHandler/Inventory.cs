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
        

        Debug.Log("Starting Inventory script");

        database = GetComponent<ItemDatabase>(); // used in AddItem()

        inventoryPanel = GameObject.Find("InventoryPanel");
        slotPanel = inventoryPanel.transform.FindChild("SlotPanel").gameObject;
        
        // create a blank slots
        for(int i = 0; i < slotAmount; i++)
        {
            items.Add(new ItemV2());
            slots.Add(Instantiate(inventorySlot));
            slots[i].GetComponent<ItemSlot>().slotID = i; // set slotID for drag/drop in ItemSlot
            slots[i].transform.SetParent(slotPanel.transform);  // allows to follow the grid layout
            

        }

        
        

    }

    void Update()
    {
        
        
        
    }

    public void AddItem(int id)
    {
        ItemV2 itemToAdd = database.FetchItemByID(id);

        
        // check for item in inventory for stacking
        if(itemToAdd.Stackable && CheckIfItemIsInInventory(itemToAdd))
        {
            Debug.Log("Attempting to add a stacked item " + id);
            for (int i = 0; i < items.Count; i++)
            {
                if(items[i].ID == id)
                {
                    ItemData data = slots[i].transform.GetChild(0).GetComponent<ItemData>();
                    data.amount++; // increase stack size by one
                    data.transform.GetChild(0).GetComponent<Text>().text = data.amount.ToString(); // update text field with stack size
                    break;
                }
            }
        }
        else
        {
            
            // find empty slot and add to inventory array and set parent
            for (int i = 0; i < items.Count; i++)
            {
                
                if (items[i].ID == -1)
                {
                    

                    items[i] = itemToAdd;
                    GameObject itemObj = Instantiate(inventoryItem);
                    itemObj.GetComponent<ItemData>().item = itemToAdd;
                    itemObj.GetComponent<ItemData>().slotLocation = i;  // location data for Drag/Drop
                    itemObj.transform.SetParent(slots[i].transform);
                    itemObj.transform.position = slots[i].transform.position;
                    //itemObj.transform.position = Vector2.zero; // placement center of the slot
                    itemObj.GetComponent<Image>().sprite = itemToAdd.Sprite;
                    itemObj.name = itemToAdd.Title;

                    

                    break;
                }
            }

        }
        
        
    }

    
    

    bool CheckIfItemIsInInventory(ItemV2 item)
    {
        for(int i = 0; i < items.Count; i++)
        {
            if (items[i].ID == item.ID)
            {
                return true;
            }
            
        }
        return false;
    }


}
