using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save : MonoBehaviour {
	public static Text globalMessage;
	public static bool globalMessageFlag = false;
	public static bool globalMessageLongFlag = false;
	public static Text topGlobalMessage;
	public static bool topGlobalMessageFlag = false;
	public static bool topGlobalMessageLongFlag = false;

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

	// Set this to true when the poison collides with the poison plane
	public static bool poisonInitiate = false;

	// PROCESS Set this to true when the player tries to break into the study
	public static bool poisonGasAnimationStart = false;

	//TEMP - remove after testing and ice is implemented
	public static bool icetesting = false;

	//Play Sounds
	public static bool journalscribble = false;
	public static bool diningRoomDoorOpenSound = false;
	public static bool kitchenDoorOpenSound = false;
	public static bool hallwayBDoorOpenSound = false;
	public static bool guestBedroomDoorOpenSound = false;
	public static bool masterBedroomDoorOpenSound = false;
	public static bool studyDoorOpenSound = false;

	void Awake(){
		globalMessage = GameObject.Find ("/Canvas/Text/globalMessage").GetComponent<Text>();
		topGlobalMessage = GameObject.Find ("/Canvas/Text/topGlobalMessage").GetComponent<Text>();
	}
	void Update(){
		if (globalMessageFlag == true) {
			StartCoroutine(FadeTextToZeroAlpha(5f, globalMessage));
			globalMessageFlag = false;
		}
		if (topGlobalMessageFlag == true) {
			StartCoroutine(FadeTextToZeroAlpha(5f, topGlobalMessage));
			topGlobalMessageFlag = false;
		}
		if (globalMessageLongFlag == true) {
			StartCoroutine(FadeTextToZeroAlpha(10f, topGlobalMessage));
			globalMessageLongFlag = false;
		}
		if (topGlobalMessageLongFlag == true) {
			StartCoroutine(FadeTextToZeroAlpha(10f, topGlobalMessage));
			topGlobalMessageLongFlag = false;
		}
	}
	public static void setGlobalMessage(string message){
		globalMessage.text = message;
		globalMessageFlag = true;
	}
	public static void setTopGlobalMessage(string message){
		topGlobalMessage.text = message;
		topGlobalMessageFlag = true;
	}
	public static void setTopGlobalMessageLong(string message){
		topGlobalMessage.text = message;
		topGlobalMessageFlag = true;
	}
	public static void setGlobalMessageLong(string message){
		globalMessage.text = message;
		globalMessageLongFlag = true;
	}
	public IEnumerator FadeTextToZeroAlpha(float t, Text i)
	{
		i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
		while (i.color.a > 0.0f)
		{
			i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
			yield return null;
		}
	}
}
