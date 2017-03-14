using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemSlotBehavior : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler {

    public Item item;
    Image itemImage;
    public int slotNumber; // index for item list
    Inventory inventory;

	// Use this for initialization
	void Start () {
        inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
        itemImage = gameObject.transform.GetChild(0).GetComponent<Image>();
		
	}
	
	// Update is called once per frame
	void Update () {
        if(inventory.Items[slotNumber].itemName != null)
        {
            item = inventory.Items[slotNumber];
            itemImage.enabled = true;
            itemImage.sprite = inventory.Items[slotNumber].itemIcon;
        }

        else
        {
            itemImage.enabled = false;
        }
		
	}
    


    // event handlers /////
    public void OnPointerDown(PointerEventData data)
    {

    }

    public void OnPointerEnter(PointerEventData data)
    {
        if(inventory.Items[slotNumber].itemName != null)
        {
            Debug.Log(inventory.Items[slotNumber].itemDesc);  // show name on mouseover
        
        }
    }
}
