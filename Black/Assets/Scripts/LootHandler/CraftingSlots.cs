using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingSlots : MonoBehaviour {

    public GameObject craftingGUI;
    public GameObject craftingPanel;
    public GameObject inventorySlot;
    public GameObject inventoryItem;
    ItemDatabase database;

    private int slotAmount = 3;

    public List<ItemV2> items = new List<ItemV2>();
    public List<GameObject> slots = new List<GameObject>();


    void Start()
    {
        Debug.Log("Starting crafting script");

        database = GetComponent<ItemDatabase>();

        for (int i = 0; i < slotAmount; i++)
        {
            items.Add(new ItemV2());
            slots.Add(Instantiate(inventorySlot));
            slots[i].GetComponent<ItemSlot>().slotID = i; // set slotID for drag/drop in ItemSlot
            slots[i].transform.SetParent(craftingPanel.transform);  // allows to follow the grid layout


        }

        // testing
        CraftItem(3);



    }

    public void CraftItem(int itemID)
    {
        ItemV2 itemToAdd = database.FetchItemByID(itemID);

        for (int i = 0; i < items.Count; i++)
        {

            if (items[i].ID == -1)
            {
                items[i] = itemToAdd;
                GameObject itemObj = Instantiate(inventoryItem);
                itemObj.GetComponent<ItemData>().item = itemToAdd;
                itemObj.GetComponent<ItemData>().slotLocation = i;  // location data for Drag/Drop
                itemObj.transform.SetParent(slots[i].transform);
                itemObj.transform.position = Vector2.zero; // placement center of the slot
                itemObj.GetComponent<Image>().sprite = itemToAdd.Sprite;
                itemObj.name = itemToAdd.Title;

                // Debug.Log("Item Added To Inventory " + items[i].ID);

                break;
            }
        }

        /*
        // check for item in enventory for stacking
        if (itemToAdd.Stackable && CheckIfItemIsInInventory(itemToAdd))
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ID == itemID)
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
                    itemObj.transform.position = Vector2.zero; // placement center of the slot
                    itemObj.GetComponent<Image>().sprite = itemToAdd.Sprite;
                    itemObj.name = itemToAdd.Title;

                    // Debug.Log("Item Added To Inventory " + items[i].ID);

                    break;
                }
            }

        }

    */

    }


    bool CheckIfItemIsInInventory(ItemV2 item)
    {
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].ID == item.ID)
            {
                return true;
            }

        }
        return false;
    }


}
