using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupHandler : MonoBehaviour {


    int slotID;
    public int itemID;
    ItemDatabase database;

    private Inventory inv;
    

    void Start()
    {
        database = GetComponent<ItemDatabase>();

        inv = GameObject.Find("InventoryPanel").GetComponent<Inventory>();

        
    }

    

    void OnTriggerEnter(Collider other)
    {
        this.GetComponent<SphereCollider>().enabled = false;
        this.GetComponent<MeshRenderer>().enabled = false;

        int itemSlotID;
        inv.AddItem(itemID);
        inv.GetItemSlotID(itemID);
        itemSlotID = inv.itemSlotID;
        

        Save.setGlobalMessage("You have picked up a " + inv.items[itemSlotID].Title);

        

        
    }

}
