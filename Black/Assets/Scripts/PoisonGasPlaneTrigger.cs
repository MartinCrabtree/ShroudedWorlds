using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonGasPlaneTrigger : MonoBehaviour {
	public AudioSource gas;
	public AudioClip poison;

	void Awake(){
		poison = Resources.Load("poison") as AudioClip;
	}
	void OnTriggerEnter(Collider other) {
		gas.clip = poison;
		gas.Play ();
		if (!Save.poisonInitiate && !Save.poisonImmune) {
			Debug.Log ("Trigger Poison Status");
			Save.poisonInitiate = true;
		}
	}
	void OnTriggerExit(Collider other) {
		Debug.Log ("Left Poison Area - Shutting Down Poison Sound");
		gas.Stop ();
	}
}
