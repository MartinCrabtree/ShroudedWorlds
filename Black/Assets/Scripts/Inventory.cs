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
        database = GameObject.FindGameObjectWithTag("ItemDatabase").GetComponent<itemDatabase>();


        for (int i = 1; i < 13; i++)
        {
            GameObject slot = (GameObject)Instantiate(slots);
            Slots.Add(slot);
            Items.Add(new Item());
            slot.transform.parent = this.gameObject.transform;

            slot.name = "Slot" + i;
            slot.GetComponent<RectTransform>().localPosition = new Vector3(x, y, 0);
            x = x + 60;
        }

        addItem(0);
        addItem(1);

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
