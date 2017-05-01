using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingStationClickHandler : MonoBehaviour {

    public GameObject craftingStation;
    public Button closeCraftingStation;
    public static bool stationIsActive = false;
    public static Inventory craftingGUI;

    void Awake()
    {
        craftingGUI = GameObject.Find("CraftingGUI").GetComponent<Inventory>();

    }

    void Start()
    {
        craftingStation = GameObject.Find("Craftstation");
        closeCraftingStation = GameObject.Find("closeCraftButton").GetComponent<Button>();


        craftingStation.gameObject.SetActive(false);
        closeCraftingStation.onClick.AddListener(CloseCraftingWindow);
    }

	void OnMouseDown(){

        craftingStation.gameObject.SetActive(true);
        stationIsActive = true;

    }

    public void CloseCraftingWindow()
    {
        craftingStation.gameObject.SetActive(false);
        stationIsActive = false;
    }

    
}
