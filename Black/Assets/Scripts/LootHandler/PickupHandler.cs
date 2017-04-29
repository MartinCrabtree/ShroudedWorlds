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

        inv.AddItem(itemID);

        this.GetComponent<SphereCollider>().enabled = false;
        this.GetComponent<MeshRenderer>().enabled = false;

        
    }

}
