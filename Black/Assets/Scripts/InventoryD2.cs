using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryD2 : MonoBehaviour
{

    // for D2 inventory background 321x434
    public Texture2D image;
    public Rect position;
    // float x;
    // float y;


    // dimenstions of the item array
    int slotWidth = 10;
    int slotHeight = 4;

    public List<ItemD2> items = new List<ItemD2>();
    public SlotD2[,] slots;

    //starting position for grid array
    public int slotx;
    public int sloty;
    public float width = 32;
    public float height = 32;

    private bool testForItem;
    

    // Use this for initialization
    void Start()
    {
        setSlots();
        testForItem = false;
        

        // how to add items and pre define. 

    }

    void itemsActive()
    {
        // seed items so they are active because of order which scripts are called
        addItem(0, 0, ItemDatabaseD2.getConsumable(0));
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
                slots[x, y] = new SlotD2(new Rect(slotx + width*x, sloty + height*y, height, width));
                
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
        // draw the item array list
        for (int counter = 0; counter < items.Count; counter++)
        {
            GUI.DrawTexture(new Rect(slotx + position.x * items[counter].x * width, sloty + position.y * items[counter].y * height, items[counter].width * width, items[counter].height * height), items[counter].image);
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
        if(x + item.width > slotWidth || y + item.height > slotHeight)
        {
            Debug.Log("Item placed out of bounds");
            return;
        }

        

        // adds item to the list with x/y coordinates
        item.x = x;
        item.y = y;
        items.Add(item);
        
        
        // set occupied slots based on item size
        
        for(int xInventory = x; xInventory < item.width + x; xInventory++)
        {
            for(int yInventory = y; yInventory < item.height + y; yInventory++)
            {
                slots[xInventory, yInventory].isOccupied = true;
            }
        }
        
    }



}
