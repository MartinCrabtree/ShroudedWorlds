using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour {

	public static bool gameOver = false;
	public static List<Lore.LoreItem> lore = new List<Lore.LoreItem>();

	// PROCESS Tracks if anything has been fed to the hearth
	public static bool hearthAdded = false;

	//Doors - change these flags to true if the correct item is in inventory, everything unlocks with crowbar except study
	public static bool diningRoomDoorOpen = false;
	public static bool kitchenDoorOpen = false;
	public static bool hallwayBDoorOpen= false;
	public static bool guestBedroomDoorOpen = false;
	public static bool masterBedroomDoorOpen = false;
	public static bool studyDoorOpen = false;

	// Ice and Poison Levels
	public static int currentIceLevel = 0;
	public static int currentPoisonLevel = 0;

	// PROCESS Set this to true when poison immunity potion is crafted
	public static bool poisonImmune = false;

	// PROCESS Set this to true when the player tries to break into the study
	public static bool poisonInitiate = false;
}
