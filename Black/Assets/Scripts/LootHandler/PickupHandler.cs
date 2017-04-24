using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupHandler : MonoBehaviour {

    public int itemID;

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
        

        this.GetComponent<SphereCollider>().enabled = false;
        this.GetComponent<MeshRenderer>().enabled = false;

        InventoryAddItem.passItemID(itemID);
    }

}
