using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // tell unity it is not modal !!!!! cannot instantiate !!!!!
public abstract class ItemD2 {

    public Texture2D image;
    // x/y for which slot the item takes up
    public int x;
    public int y;


    public int width;
    public int height;

    public abstract void performAction(); // will be extended elsewhere


}
