using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;

/// <summary>
/// for Inventory V2
/// populates item data from JSON database
/// </summary>

public class ItemDatabase : MonoBehaviour {
    private List<ItemV2> database = new List<ItemV2>();
    private JsonData itemData;

    void Start()
    {
        // pull data from json file in assets folder
        itemData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/StreamingAssets/Items.json"));

        ConstructItemDatabase();

        //Debug.Log("Test output for itemDatabase " + database[1].Title);
    }

    public ItemV2 FetchItemByID(int id)
    {
        for(int i = 0; i <  database.Count; i++)
        {
            if (database[i].ID == id)
            {
                return database[i];
            }
                        
        }
        Debug.Log("Item not found by FetchItemByID");
        return null;
    }

    


    void ConstructItemDatabase()
    {
        for (int i = 0; i < itemData.Count; i++)
        {
            // populate item list from file
            database.Add(new ItemV2((int)itemData[i]["id"], itemData[i]["title"].ToString(), (int)itemData[i]["value"], itemData[i]["imagefile"].ToString(),(bool)itemData[i]["craftable"]));
        }
    }
}

public class ItemV2
{
    public int ID { get; set; }
    public string Title { get; set; }
    public int Value { get; set; }
    public bool Craftable { get; set; }
    public string Imagefile { get; set; }
    public Sprite Sprite { get; set; }

    public ItemV2(int id, string title, int value, string imagefile, bool craftable)
    {
        this.ID = id;
        this.Title = title;
        this.Value = value;
        this.Craftable = craftable;
        this.Sprite = Resources.Load<Sprite>(imagefile);
        Debug.Log("The image file being loaded is " + imagefile);
    }

    // probably won't use value so constructor without
    public ItemV2(int id, string title, string imagefile, bool craftable)
    {
        this.ID = id;
        this.Title = title;
        this.Craftable = craftable;
        this.Sprite = Resources.Load<Sprite>(imagefile);
        Debug.Log("The image file being loaded is " + imagefile);
    }

    public ItemV2()
    {
        this.ID = -1;
    }

    /*
    public ItemV2 Add()
    {
        return new ItemV2();
    }
    */

    
}
