using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    public GameObject slots;
    public List<GameObject> Slots =  new List<GameObject>();
    public List<Item> Items = new List<Item>();
    itemDatabase database;

    // starting xy coords in the gui
    int x = -691;
    int y = 7;

    void Start()
    {
        int slotAmount = 0;

        database = GameObject.FindGameObjectWithTag("itemDatabase").GetComponent<itemDatabase>();
               

        for (int i = 1; i < 13; i++)
        {
            GameObject slot = (GameObject)Instantiate(slots);
            slot.GetComponent<ItemSlotBehavior>().slotNumber = slotAmount;
            Slots.Add(slot);
            Items.Add(new Item());
            slot.GetComponent<RectTransform>().localPosition = new Vector3(x, y, 0);
            slot.transform.parent = this.gameObject.transform;

            slot.name = "Slot" + i;
           
            x = x + 60; // move new slot to the right 60px
            slotAmount++;
        }

       // addItem(0);
       //  addItem(1);

    }



    // add items to the inventory array
    void addItem(int id)
    {
        for(int i = 0; i < database.items.Count; i++)
        {
            if(database.items[i].itemID == id)
            {
                Item item = database.items[i];
                addItemEmptySlot(item);
                break;
            }
        }
    }


    // find an empty slot in the item array to insert new items
    void addItemEmptySlot(Item item)
    {
        for(int i = 0; i < Items.Count; i++)
        {
            if(Items[i].itemName == null)
            {
                Items[i] = item;
                break;
            }
        }
    }

}
