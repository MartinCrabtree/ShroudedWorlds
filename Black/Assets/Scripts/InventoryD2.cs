﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryD2 : MonoBehaviour
{

    // position.width position.height  not set


    // for D2 inventory background 321x434
    public Texture2D image;
    public Rect position;
    // float x;
    // float y;


    // dimenstions of the item array
    int slotWidth = 10;
    int slotHeight = 4;


    public List<ItemD2> items = new List<ItemD2>();   // actual list of items
    public SlotD2[,] slots;

    //starting position for grid array
    public int slotx;
    public int sloty;
    public float width = 32;
    public float height = 32;

    private bool testForItem;
    public static bool inventoryActive; // detects mouseover inventory
    
    

	public ItemDatabaseD2 itemDB; 

    // Use this for initialization
    void Start()
    {

		itemDB = new ItemDatabaseD2 ();
			
        setSlots();
        testForItem = false;
        

        // how to add items and pre define. 

    }

    void itemsActive()
    {

        // seed items so they are active because of order which scripts are called
        
		//SEARCH FOR ITEM BY NAME
		addItem(0, 0, itemDB.getConsumable("healingpot"));
        addItem(1, 1, itemDB.getConsumable("unlit torch")); ///// DOES NOT WORK


                
        testForItem = true;
    }

    // Update is called once per frame
    void Update()
    {



        if (!testForItem)
        {
            itemsActive();
        }
    }


    void setSlots()
    {
        slots = new SlotD2[slotWidth, slotHeight];
        //SlotD2.test = test;

        // setting the overlay grid for the inventory

        for (int x = 0; x < slotWidth; x++)
        {
            for (int y = 0; y < slotHeight; y++)
            {
                slots[x, y] = new SlotD2(new Rect(slotx + width * x, sloty + height * y, height, width));
                

                // Debug.Log("test");
            }
        }
    }


    void OnGUI()
    {
        drawInventory();
        drawSlots();
        drawItems();

        

    }

    void drawSlots()
    {
        for (int x = 0; x < slotWidth; x++)
        {
            for (int y = 0; y < slotHeight; y++)
            {
                slots[x, y].draw(position.x, position.y);

                // Debug.Log("test");
            }
        }
    }

    void drawInventory()
    {
        // set position of inventory
        position.x = Screen.width - position.width;
        position.y = Screen.height - position.height - Screen.height * 0.2f;

        GUI.DrawTexture(position, image);
    }

    void drawItems()
    {

        // !!!!!!!!!!!!!! NEEED TO FIX SO IT DRAWS FROM AN ITEM LIST


        // draw the item array list

        


        
        for (int counter = 0; counter < items.Count; counter++)
        {
            Debug.Log("Draw Items Counter" + counter);
            Debug.Log("items.Count" + items.Count);
            GUI.DrawTexture(new Rect(width * counter + position.x + 20, sloty + position.y + height + 2, width, height), items[counter].image);
            //GUI.DrawTexture(new Rect(slotx * counter + position.x + 2, sloty + position.y + height + 2 , width, height), items[counter].image);

        }
        

    }


    public void addItem(int x, int y, ItemD2 item)
    {
        // x/y number of slots the item takes up
        
        
        for (int xInventory = 0; xInventory <item.width; xInventory++)
        {
            for(int yInventory = 0; yInventory < item.height; yInventory++)
            {
                if (slots[x, y].isOccupied)
                {
                    return;
                }
            }
        }

        // make sure the item isn't being placed out of bounds
        /*
        if(x + item.width > slotWidth || y + item.height > slotHeight)
        {
            Debug.Log("Item placed out of bounds");

			//GRACE ADDED
			Debug.Log ("x: " + x);
			Debug.Log ("y: " + y);
			Debug.Log ("item.width: " + item.width);
			Debug.Log ("slotWidth: " + slotWidth);
			Debug.Log ("item.height: " + item.height);
			Debug.Log ("slotHeight: " + slotHeight);

			Debug.Log ("x + item.width > slotWidth: ");
			Debug.Log (x + item.width > slotWidth);
			Debug.Log ("y + item.height > slotHeight: ");
			Debug.Log (y + item.height > slotHeight);
            return;
        }
        */

        

        // adds item to the list with x/y coordinates
        item.x = x;
        item.y = y;
        
        items.Add(item);
        
        
        // set occupied slots based on item size
        // changing all items to 1x1 square in inventory grid
        /*
        for(int xInventory = x; xInventory < item.width + x; xInventory++)
        {
            for(int yInventory = y; yInventory < item.height + y; yInventory++)
            {
                slots[xInventory, yInventory].isOccupied = true;
            }
        }
        */
        

    }

}
