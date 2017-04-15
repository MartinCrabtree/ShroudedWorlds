using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryAddItem : MonoBehaviour {
    public GameObject inventoryWindow;
    public GameObject[] inventoryIcons;

    void OnCollisionEnter(Collision collision)
    {
        // check to see if item is already in inventory add if new object
        foreach(Transform child in inventoryWindow.transform)
        {
            if(child.gameObject.tag == collision.gameObject.tag)
            {
                return;
            }
                     
        }


        GameObject newItem;
        if (collision.gameObject.tag == "KeySilver")
        {
            newItem = Instantiate(inventoryIcons[0]);
            newItem.transform.SetParent(inventoryWindow.transform);
        }
        else if (collision.gameObject.tag == "Herb")
        {
            newItem = Instantiate(inventoryIcons[1]);
            newItem.transform.SetParent(inventoryWindow.transform);
        }
        else if (collision.gameObject.tag == "Tenderizer")
        {
            newItem = Instantiate(inventoryIcons[2]);
            newItem.transform.SetParent(inventoryWindow.transform);
        }
        else if (collision.gameObject.tag == "Crowbar")
        {
            newItem = Instantiate(inventoryIcons[3]);
            newItem.transform.SetParent(inventoryWindow.transform);
        }


    }

}
