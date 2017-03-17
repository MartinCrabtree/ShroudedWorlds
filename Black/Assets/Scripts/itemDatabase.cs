using System;
using System.Collections;
using System.Collections.Generic; // needed for lists
using UnityEngine;

public class itemDatabase : MonoBehaviour {
    public List<Item> items = new List<Item>();

    void Start()
    {
        items.Add(new Item("I_Key01", 0, "It's a key", 10, 10, 1, Item.ItemType.Key)); // bedroom door key level 1
        items.Add(new Item("I_Torch01", 1, "An unlit torch", 10, 10, 1, Item.ItemType.Consumable));
        items.Add(new Item("I_Torch02", 2, "A burning torch", 10, 10, 1, Item.ItemType.Consumable));
        items.Add(new Item("I_Book04", 3, "A book of matches", 10, 10, 1, Item.ItemType.Consumable));
    }
	
}
