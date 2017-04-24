using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryAddItem : MonoBehaviour {

    public GameObject inventoryPanel;
    public GameObject slotPanel;
    
    int pickupObjectID;  

    private Inventory inv; // get access to inventory object
    
    void Start()
    {
        inventoryPanel = GameObject.Find("InventoryPanel");
        slotPanel = inventoryPanel.transform.FindChild("SlotPanel").gameObject;


    }

   
    

    void OnTriggerEnter(Collider collision)
    {
        //Debug.Log(pickupObjectID);
        // add object to inventory window
        //addToInventory(pickupObjectID);
        //Inventory.InventoryTest(pickupObjectID);
        
        
    }


    void addToInventory(int pickupObjectID)
    {
        Debug.Log("Attempting to pickup object ID " + pickupObjectID);
        inv.AddItem(pickupObjectID);
        
        
        // inv.AddItem(pickupObjectID);
    }

    public static void passItemID(int pickupObjectID)
    {
        Inventory.InventoryTest(pickupObjectID);
    }


    /*
    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Inventory Add Item ");
        
        // check to see if item is already in inventory add if new object
        foreach (Transform child in inventoryWindow.transform)
        {
            if (child.gameObject.tag == collision.gameObject.tag)
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

*/
    
   












    /*
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
*/



}
