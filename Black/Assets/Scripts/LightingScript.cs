using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingScript : MonoBehaviour {

	public GameObject HallwayALights;
	public GameObject StorageRoomLights;
	public GameObject DiningRoomLights;
	public GameObject KitchenLights;
	public GameObject StartingRoomLights;


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
	
	// Update is called once per frame
	void Update () {
		
	}

	public void lightRoom (string roomName){
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
}
