using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class SlotD2{

    public ItemD2 item;
    public bool isOccupied;
    public Rect position;

    // public static Texture2D test;


    public SlotD2(Rect position)
    {
        this.position = position;
    }



    public void draw(float frameX, float frameY)
    {
        if (item != null)
        {
            GUI.DrawTexture(new Rect(frameX + position.x, frameY + position.y, position.width, position.height), item.image);  
        }
        
    }
}
