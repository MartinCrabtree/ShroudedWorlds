using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// attached to item prefab when they are added to the inventory, also handles Drag/Drop
/// Make sure a layout element is added to the item prefab, and check ignore layout, so that it ignores parent layout upon drag
/// </summary>
/// 

/*

public class ItemData : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler
{

    public ItemV2 item;
    public int amount;
    public int slotLocation; // for drag/drop location
    private Transform originalSlotLoc;


    private Inventory inv;
    private Inventory craftingPanel;

    private Vector2 offset;  // mouse position offset so mouse cursor stays in the center of the icon

    void Awake()
    {
        inv = GameObject.Find("InventoryPanel").GetComponent<Inventory>();
        //craftingPanel = GameObject.Find("CraftingGUI").GetComponent<Inventory>();
    }


    void Start()
    {


    }



    public void OnPointerClick(PointerEventData eventData)
    {



        if (eventData.button == PointerEventData.InputButton.Left)
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

            Debug.Log("Left click");


        }

        else if (eventData.button == PointerEventData.InputButton.Middle)
        {
            Debug.Log("Middle click");


        }

        else if (eventData.button == PointerEventData.InputButton.Right)
        {
            Debug.Log("Right click");
            int itemID = this.item.ID;


            if (item != null)
            {
                // check to see if the object is in the crafting or inventory panel
                if (this.GetComponentInParent<Inventory>() == craftingPanel)
                {

                    // create the same item in inventory
                    inv.AddItem(itemID);

                    // delete the item in crafting window
                    for (int i = 0; i < craftingPanel.items.Count; i++)
                    {
                        if (craftingPanel.items[i].ID == itemID)
                        {
                            craftingPanel.RemoveItem(i);
                        }
                    }

                }

                // if the item is in the inventory panel
                if (this.GetComponentInParent<Inventory>() == inv && this.item.Craftable == true)
                {

                    // check to make sure there is room in the crafting window
                    for (int i = 0; i < craftingPanel.items.Count; i++)
                    {
                        if (craftingPanel.items[i].ID == -1)
                        {

                            for (int counter = 0; counter < inv.items.Count; counter++)
                            {
                                if (inv.items[counter].ID == itemID)
                                {
                                    // create the same item in crafting window and delete item in inventory window
                                    craftingPanel.AddItem(itemID);
                                    inv.RemoveItem(counter);
                                    break;
                                }
                            }

                        }
                    }


                }


            }


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
*/