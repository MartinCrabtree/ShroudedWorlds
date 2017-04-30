using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// attached to item prefab when they are added to the inventory, also handles Drag/Drop
/// Make sure a layout element is added to the item prefab, and check ignore layout, so that it ignores parent layout upon drag
/// </summary>

public class ItemData : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerDownHandler {

    public ItemV2 item;
    public int amount;
    public int slotLocation; // for drag/drop location
    private Transform originalSlotLoc;
        

    private Inventory inv;
    
    private Vector2 offset;  // mouse position offset so mouse cursor stays in the center of the icon

    void Start()
    {
        inv = GameObject.Find("InventoryPanel").GetComponent<Inventory>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // make sure there is an item in the slot
        if (item != null)
        {
            // capture original location of slot transform
            originalSlotLoc = this.transform;

            offset = eventData.position - new Vector2(this.transform.position.x, this.transform.position.y); // had to convert vector3 positioning


            // set parent to slot panel so it doesn't get hidden by other sprites on the inventory

            
            this.transform.SetParent(this.transform.parent.parent);

            this.transform.position = eventData.position - offset; // vector2 mouse position

            GetComponent<CanvasGroup>().blocksRaycasts = false; // disable raycast through icon while dragging


        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (item != null)
        {
            

            // actual icon dragging
            this.transform.position = eventData.position - offset; 
            
            
        }
    }

    public void OnEndDrag(PointerEventData eventData)  //// used after OnDrop in ItemSlot
    {
        
        

        this.transform.SetParent(inv.slots[slotLocation].transform);  // sets parent to mouse location
        this.transform.position = inv.slots[slotLocation].transform.position;

        

        GetComponent<CanvasGroup>().blocksRaycasts = true; // enable raycast again once icon is placed
        
    }
}
