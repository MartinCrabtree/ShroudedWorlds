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



    // Use this for initialization
    void Start()
    {
        setSlots();

    }

    // Update is called once per frame
    void Update()
    {

    }


    void setSlots()
    {
        slots = new SlotD2[slotWidth, slotHeight];

        // setting the overlay grid for the inventory

        for (int x = 0; x < slotWidth; x++)
        {
            for (int y = 0; y < slotHeight; y++)
            {
                slots[x, y] = new SlotD2();

                Debug.Log("test");
            }
        }
    }


    void OnGUI()
    {

        // set position of inventory
        position.x = Screen.width - position.width;
        position.y = Screen.height - position.height - Screen.height * 0.2f;

        GUI.DrawTexture(position, image);
    }



}
