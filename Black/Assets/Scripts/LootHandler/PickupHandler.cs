using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupHandler : MonoBehaviour {


    int slotID;
    public int itemID;
    private Inventory inv;
    ItemDatabase database;

    void Start()
    {
        inv = GameObject.Find("InventoryPanel").GetComponent<Inventory>();
        database = GetComponent<ItemDatabase>();
    }

    

    // item dissapears when player collides
    /*
	void OnCollisionEnter()
    {
        this.GetComponent<SphereCollider>().enabled = false;
        this.GetComponent<MeshRenderer>().enabled = false;
    }
    */
    

    void OnTriggerEnter(Collider other)
    {
        ItemV2 itemToAdd = database.FetchItemByID(itemID);

        inv.items.Add(itemToAdd);

        this.GetComponent<SphereCollider>().enabled = false;
        this.GetComponent<MeshRenderer>().enabled = false;

        //InventoryAddItem.passItemID(itemID);
    }

}
