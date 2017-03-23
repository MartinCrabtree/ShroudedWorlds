using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabaseD2 : MonoBehaviour {

    public List<ConsumableD2> consumablesInspector;

    private static List<ConsumableD2> consumables;  // !!! static list !!!
    
	//FOR CREATING CONSUMABLE ITEMS
	public ConsumableD2 consumable;
	//FOR PLACEHOLDER SO THAT RETURN IS WITHIN SCOPE IN FUNCTION GETCONSUMABLE BELOW
	public ConsumableD2 consumablePlaceholder;

    void Start()
    {
        consumables = consumablesInspector;

        //CREATE ALL ITEMS HERE
        // consumable = new ConsumableD2(1,"healingpot","A_Armor04", 10, 4);
        consumable = new ConsumableD2(1, "healingpot", "A_Armor04", 10, 4);
        consumable = new ConsumableD2(2, "unlit torch", "I_Torch01", 10, 4);
    }
		
    // create a new instance of consumable when a new item is added

	//SEARCH FOR CONSUMABLE BY NAME
	public ConsumableD2 getConsumable(string itemName)
    {
		consumablePlaceholder = new ConsumableD2 ();
		//SEARCH THROUGH CURRENT INVENTORY DATABASE OF CREATED ITEMS
		foreach (ItemD2 item in ItemD2.inventoryDatabase) {
			if (item.name == itemName) {
				Debug.Log (item.name + " is found");
				consumablePlaceholder.image = item.image;
                consumablePlaceholder.width = item.width;
                consumablePlaceholder.height = item.height;
                consumablePlaceholder.name = item.name;
				consumablePlaceholder.count = item.count;
			} else {
				Debug.Log (item.name + " is not found");
			}
		}
		return consumablePlaceholder;
    }
}
