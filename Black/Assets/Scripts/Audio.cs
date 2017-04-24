using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {
	// List of all audio clips
	public List<AudioObject> audioClips = new List<AudioObject>();
	// References the audioSources as specified by attaching in the inspector under Game script in Main Camera Hierarchy object
	public AudioSource audioSourceAmbient;
	public AudioSource audioSourceOne;
	public AudioSource audioSourceTwo;
	// These are used in helper functions, specified here to be within scope of return in those functions
	public AudioClip clip;

	// Wrapper object for each audio clip
	public class AudioObject{
		public AudioClip audioClip;
		public string clipName;

		public AudioObject(string name, string source){
			audioClip = Resources.Load(source) as AudioClip;
			clipName = name;
		}
	}
	// Called before any Start functions
	void Awake(){
		// Add all audioclips to the list of audioclips
		audioClips.Add(new AudioObject("ambient", "ambient"));
		audioClips.Add(new AudioObject("unlock", "unlock"));
		audioClips.Add(new AudioObject("scribble", "scribble"));
	}
	// Called before the first frame update
	void Start () {
		PlayAmbient ("ambient");
		//Test audio playback
//		PlaySoundOne ("audioone");
//		PlaySoundTwo ("audiotwo");
	}
	// Called once per frame
	void Update () {
		// Auto play based on boolean
		if(Save.journalscribble == true){
			PlaySoundOne ("scribble");
			Save.journalscribble = false;
		}
		if(Save.diningRoomDoorOpenSound == true){
			PlaySoundOne ("unlock");
			Save.diningRoomDoorOpenSound = false;
		}
		if(Save.kitchenDoorOpenSound == true){
			PlaySoundOne ("unlock");
			Save.kitchenDoorOpenSound = false;
		}
		if(Save.hallwayBDoorOpenSound == true){
			PlaySoundOne ("unlock");
			Save.hallwayBDoorOpenSound = false;
		}
		if(Save.guestBedroomDoorOpenSound == true){
			PlaySoundOne ("unlock");
			Save.guestBedroomDoorOpenSound = false;
		}
		if(Save.masterBedroomDoorOpenSound == true){
			PlaySoundOne ("unlock");
			Save.masterBedroomDoorOpenSound = false;
		}
		if(Save.studyDoorOpenSound == true){
			PlaySoundOne ("unlock");
			Save.studyDoorOpenSound = false;
		}
	}
	// HELPER FUNCTIONS

	// Retrieve audio clip by name
	public AudioClip getAudioClip(string name){
		foreach (AudioObject item in audioClips) {
			if(item.clipName == name){
				clip = item.audioClip;
			}
		}
		return clip;
	}
	// The following plays an audio clip from an audioObject as referenced by the name, by audio source as specified
	public void PlayAmbient(string name){
		foreach (AudioObject item in audioClips) {
			if(item.clipName == name){
				audioSourceAmbient.clip = item.audioClip;
				audioSourceAmbient.Play ();
			}
		}
	}
	public void PlaySoundOne(string name){
		foreach (AudioObject item in audioClips) {
			if(item.clipName == name){
				audioSourceOne.clip = item.audioClip;
				audioSourceOne.Play ();
			}
		}
	}
	public void PlaySoundTwo(string name){
		foreach (AudioObject item in audioClips) {
			if(item.clipName == name){
				audioSourceTwo.clip = item.audioClip;
				audioSourceTwo.Play ();
			}
		}
	}
}
