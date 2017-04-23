using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// Handles item swapping for Drag/Drop updates item data when the item is dropped
/// </summary>


public class ItemSlot : MonoBehaviour, IDropHandler
{
    public int slotID;
    private Inventory inv;

    void Start()
    {
        inv = GameObject.Find("Inventory").GetComponent<Inventory>();
    }


    public void OnDrop(PointerEventData eventData)
    {
        ItemData droppedItem = eventData.pointerDrag.GetComponent<ItemData>();

        // see if an item is already in the slot being dropped on
        if (inv.items[slotID].ID == -1)
        {
            // probably redundant
            // droppedItem.transform.SetParent(this.transform);
            // droppedItem.transform.position = this.transform.position;
            inv.items[droppedItem.slotLocation] = new ItemV2();  // clear out previous item slot and set to null
            inv.items[slotID] = droppedItem.item;

            droppedItem.slotLocation = slotID;
        }
        else // swap items if an item already exists
        {
            Transform slotOccupied = this.transform.GetChild(0);
            // swap position of placed item with the original location of the item being dropped
            slotOccupied.GetComponent<ItemData>().slotLocation = droppedItem.slotLocation;
            slotOccupied.transform.SetParent(inv.slots[droppedItem.slotLocation].transform);
            slotOccupied.transform.position = inv.slots[droppedItem.slotLocation].transform.position;

            // update location of the item being dropped to destination location
            droppedItem.slotLocation = slotID;
            droppedItem.transform.SetParent(this.transform);
            droppedItem.transform.position = this.transform.position;


            /// need to walk through the logic here, it should update the slot locations in the Item Data list
            inv.items[droppedItem.slotLocation] = slotOccupied.GetComponent<ItemData>().item;
            inv.items[slotID] = droppedItem.item;

        }

    }
}
