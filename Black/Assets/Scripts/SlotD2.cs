using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class SlotD2 {

    public ItemD2 item;
    public bool isOccupied;
    public Rect position;

    public Texture2D test;


    void Slot()
    {

    }



    void draw()
    {
        GUI.DrawTexture(position, item.image);
    }
}
