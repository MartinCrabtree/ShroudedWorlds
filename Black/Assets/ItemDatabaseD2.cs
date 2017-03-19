using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabaseD2 : MonoBehaviour {

    public static List<ItemD2> consumables;  // !!! static list !!!
    public List<ItemD2> consumablesInspector;

    void Start()
    {
        consumables = consumablesInspector;

    }
}
