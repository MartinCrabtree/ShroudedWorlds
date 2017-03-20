using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabaseD2 : MonoBehaviour {

    public List<ConsumableD2> consumablesInspector;
    private static List<ConsumableD2> consumables;  // !!! static list !!!
    
    void Start()
    {
        consumables = consumablesInspector;

    }


    // create a new instance of consumable when a new item is added
    public static ConsumableD2 getConsumable(int id)
    {
        ConsumableD2 consumable = new ConsumableD2();
        ConsumableD2.image = ItemD2.consumable[id].image;
        consumable.width = ItemD2.consumable[id].width;
        consumable.height = ItemD2.consumable[id].height;

        return consumable;
    }
}
