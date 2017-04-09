using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour {

	public static bool gameOver = false;
	public static List<Lore.LoreItem> lore = new List<Lore.LoreItem>();

	public static int iceLevel;
	public static int poisonLevel;

	//Doors
	public static bool diningRoomDoorOpen = false;
	public static bool kitchenDoorOpen = false;
	public static bool hallwayBDoorOpen= false;
	public static bool guestBedroomDoorOpen = false;
	public static bool masterBedroomDoorOpen = false;
	public static bool studyDoorOpen = false;

	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
	}
}
