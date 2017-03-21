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

	//THIS IS THE WHOLE DATABASE OF ALL ITEMS EVER CREATED, NOT NECESSARILY IN THE CURRENT PLAYER's INVENTORY
	public static List<ItemD2> inventoryDatabase = new List<ItemD2>();

	//ADDED ADDITIONAL OBJECT PROPERTY VARIABLES
	public int count;
	public string name;

	//TWO CONSTRUCTORS ARE NEEDED
	public ItemD2(int countTotal, string itemName, string imageName, int itemWidth, int itemHeight){
		count = countTotal;
		name = itemName;
		width = itemWidth;
		height = itemHeight;
		image = Resources.Load<Texture2D> (imageName);
		//UPON CREATING THE ITEM, ADD IT TO OUR MAIN DATABASE OF ITEMS
		inventoryDatabase.Add (this);
	} 
	public ItemD2(){
		
	}
}
