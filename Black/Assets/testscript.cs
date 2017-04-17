using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testscript : MonoBehaviour {
//	void OnControllerColliderHit(ControllerColliderHit hit){
//			Debug.Log ("collison detected");
//	}
	void OnTriggerEnter(Collider other) {
		Debug.Log ("collison detected");
	}
}
