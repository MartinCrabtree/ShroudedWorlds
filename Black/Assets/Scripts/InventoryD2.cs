using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryD2 : MonoBehaviour
{

    // for D2 inventory background 321x434
    public Texture2D image;
    public Rect position;
    float x;
    float y;

    int slotWidth = 10;
    int slotHeight = 4;

    public List<ItemD2> items = new List<ItemD2>();
    public SlotD2[,] slots;

    //starting position for grid array
    public int slotx;
    public int sloty;
    public float width = 32;
    public float height = 32;

    // for testing purposes
    // public Texture2D test;



    // Use this for initialization
    void Start()
    {
        setSlots();
        // addItem(0,0,items.item[0]);   ***** WTF NEED TO FIX ************************************

    }

    // Update is called once per frame
    void Update()
    {

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
        // adds item
        items.Add(item);
        
        
        // set occupied slots based on item size
        
        for(int xInventory = 0; xInventory < item.width + x;)
        {
            for(int yInventory = 0; yInventory < item.height + y; yInventory++)
            {
                slots[xInventory, yInventory].isOccupied = true;
            }
        }
        
    }



}
