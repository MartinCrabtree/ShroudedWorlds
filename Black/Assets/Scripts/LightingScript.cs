using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingScript : MonoBehaviour {

	public static GameObject HallwayALights;
	public static GameObject StorageRoomLights;
	public static GameObject DiningRoomLights;
	public static GameObject KitchenLights;
	public static GameObject StartingRoomLights;
	public static GameObject EastWingLights; // Rest of the lights on the east wing
	public static GameObject HearthFire;
	public static GameObject PlayerLight;
	public static GameObject HallwayALightSwitch;
	public static GameObject StorageRoomLightSwitch;
	public static GameObject DiningRoomLightSwitch;
	public static GameObject KitchenLightSwitch;
	public static GameObject StartingRoomLightSwitch;


	void Awake (){
		HallwayALights = GameObject.Find ("/Canvas/RoomLights/HallwayALights");
		StorageRoomLights = GameObject.Find ("/Canvas/RoomLights/StorageRoomLights");
		DiningRoomLights = GameObject.Find ("/Canvas/RoomLights/DiningRoomLights");
		KitchenLights = GameObject.Find ("/Canvas/RoomLights/KitchenLights");
		StartingRoomLights = GameObject.Find ("/Canvas/RoomLights/StartingRoomLights");
		EastWingLights = GameObject.Find ("/LIGHTS");
		HearthFire = GameObject.Find ("/Canvas/Hearth/firewood");
		PlayerLight = GameObject.Find ("/player camera/player/lightsource");

		HallwayALightSwitch = GameObject.Find ("/Canvas/RoomLights/LightSwitch - HallwayA");
		StorageRoomLightSwitch = GameObject.Find ("/Canvas/RoomLights/LightSwitch - StorageRoom");
		DiningRoomLightSwitch = GameObject.Find ("/Canvas/RoomLights/LightSwitch - DiningRoom");
		KitchenLightSwitch = GameObject.Find ("/Canvas/RoomLights/LightSwitch - Kitchen");
		StartingRoomLightSwitch = GameObject.Find ("/Canvas/RoomLights/LightSwitch - StartRoom");
	}
	// Use this for initialization
	void Start () {
		HallwayALights.gameObject.SetActive (false);
		StorageRoomLights.gameObject.SetActive (false);
		DiningRoomLights.gameObject.SetActive (false);
		KitchenLights.gameObject.SetActive (false);
		StartingRoomLights.gameObject.SetActive (false);
		EastWingLights.gameObject.SetActive (false);
		HearthFire.gameObject.SetActive (false);
		PlayerLight.gameObject.SetActive (false);
	}
	// Enables the room lights for said rooms
	public static void lightRoom (string roomName){
		if (roomName == "HallwayA") {
			HallwayALights.gameObject.SetActive (true);
		} else if (roomName == "StorageRoom") {
			StorageRoomLights.gameObject.SetActive (true);
		} else if (roomName == "DiningRoom") {
			DiningRoomLights.gameObject.SetActive (true);
		} else if (roomName == "Kitchen") {
			KitchenLights.gameObject.SetActive (true);
		} else if (roomName == "StartingRoom") {
			StartingRoomLights.gameObject.SetActive (true);
		}
	}
	// Disables the room lights for said rooms
	public static void unLightRoom (string roomName){
		if (roomName == "HallwayA") {
			HallwayALights.gameObject.SetActive (false);
		} else if (roomName == "StorageRoom") {
			StorageRoomLights.gameObject.SetActive (false);
		} else if (roomName == "DiningRoom") {
			DiningRoomLights.gameObject.SetActive (false);
		} else if (roomName == "Kitchen") {
			KitchenLights.gameObject.SetActive (false);
		} else if (roomName == "StartingRoom") {
			StartingRoomLights.gameObject.SetActive (false);
		}
	}
	// Sets the hearth to be burning or not
	public static void lightHearth (bool truefalse){
		if (truefalse == true){
			HearthFire.gameObject.SetActive (true);
			Save.icetesting = true;
		} else if (truefalse == false){
			HearthFire.gameObject.SetActive (false);
		}
	}
	public static void lightPlayer (bool truefalse){
		if (truefalse == true){
			PlayerLight.gameObject.SetActive (true);
		} else if (truefalse == false){
			PlayerLight.gameObject.SetActive (false);
		}		
	}
}