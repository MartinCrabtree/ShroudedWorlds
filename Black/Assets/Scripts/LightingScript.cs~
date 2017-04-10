using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingScript : MonoBehaviour {

	public static GameObject HallwayALights;
	public static GameObject StorageRoomLights;
	public static GameObject DiningRoomLights;
	public static GameObject KitchenLights;
	public static GameObject StartingRoomLights;

	void Awake (){
		HallwayALights = GameObject.Find ("/Canvas/RoomLights/HallwayALights");
		StorageRoomLights = GameObject.Find ("/Canvas/RoomLights/StorageRoomLights");
		DiningRoomLights = GameObject.Find ("/Canvas/RoomLights/DiningRoomLights");
		KitchenLights = GameObject.Find ("/Canvas/RoomLights/KitchenLights");
		StartingRoomLights = GameObject.Find ("/Canvas/RoomLights/StartingRoomLights");
	}
	// Use this for initialization
	void Start () {
		HallwayALights.gameObject.SetActive (false);
		StorageRoomLights.gameObject.SetActive (false);
		DiningRoomLights.gameObject.SetActive (false);
		KitchenLights.gameObject.SetActive (false);
		StartingRoomLights.gameObject.SetActive (false);
	}
	// Enables the room lights for said rooms
	public static void lightRoom (string roomName){
		if (roomName == "HallwayA") {
			Debug.Log ("lighting Hallway A");
			HallwayALights.gameObject.SetActive (true);
		} else if (roomName == "StorageRoom") {
			Debug.Log ("lighting Storage Room");
			StorageRoomLights.gameObject.SetActive (true);
		} else if (roomName == "DiningRoom") {
			Debug.Log ("lighting Dining Room");
			DiningRoomLights.gameObject.SetActive (true);
		} else if (roomName == "Kitchen") {
			Debug.Log ("lighting Kitchen");
			KitchenLights.gameObject.SetActive (true);
		} else if (roomName == "StartingRoom") {
			Debug.Log ("lighting Starting Room");
			StartingRoomLights.gameObject.SetActive (true);
		}
	}
}
