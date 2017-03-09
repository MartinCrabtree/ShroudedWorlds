using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {

    public string itemName;
    public int itemID;
    public string itemDesc;
    public Sprite itemIcon;
    public GameObject itemModel;
    public int itemPower;
    public int itemSpeed;
    public int itemValue; // stack size
    public ItemType itemType;

    public enum ItemType
    {
        Weapon,
        Key,
        Consumable,
        Quest,
        Head,
        Shoes,
        Chest,
        Pants,
        Earring,
        Necklace,
        Ring,
        Hands
  
    }

    public Item(string name, int id, string desc, int power, int speed, int value, ItemType type)
    {
        itemName = name;
        itemID = id;
        itemDesc = desc;
        itemPower = power;
        itemSpeed = speed;
        itemValue = value;
        itemType = type;
        itemIcon = Resources.Load<Sprite>("" + name);

    }

    public Item()
    {
        // for an enmpty slot
    }
}
