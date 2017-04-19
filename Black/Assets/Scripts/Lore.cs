using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lore : MonoBehaviour {
	
	public class LoreItem{
		public string loreText;
		public string lorePicture;
		public string loreName;
		public bool locked;

		public LoreItem(string newText, string newImage, string newName){
			loreText = newText;
			lorePicture = newImage;
			loreName = newName;
			locked = true;
		}
	}
	void Awake(){
		//FREDRIK Create
		Save.lore.Add(new LoreItem("this is a test for 1", "stock1", "testLoreObject"));
		Save.lore.Add(new LoreItem("the bed is magical", "lorebed", "bed"));
		Save.lore.Add(new LoreItem("this is a test for 3", "stock3", "fakename3"));
		Save.lore.Add(new LoreItem("this is a test for 4", "stock4", "fakename4"));
		Save.lore.Add(new LoreItem("this is a test for 5", "stock1", "fakename5"));
		Save.lore.Add(new LoreItem("this is a test for 6", "stock2", "fakename6"));
	}
	// Use this for initialization
	void Start () {}
	// Update is called once per frame
	void Update () {}

	public static void loreUpdate(string name){
		foreach (Lore.LoreItem item in Save.lore) {
			if(item.loreName == name){
				item.locked = false;
				//Play scribble sound
				Save.journalscribble = true;
				Debug.Log (item.loreName + " locked status is now " + item.locked);
			}
			Debug.Log (item.loreName + " locked status is now " + item.locked);
		}
//		Debug.Log ("Save.JournalScribble is: " + Save.journalscribble);
	}
}
