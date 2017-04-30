using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {
	// List of all audio clips
	public List<AudioObject> audioClips = new List<AudioObject>();
	// References the audioSources as specified by attaching in the inspector under Game script in Main Camera Hierarchy object
	public AudioSource audioSourceAmbient;
	public AudioSource audioSourceFootsteps;
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
		audioClips.Add(new AudioObject("teleport", "teleport"));
		audioClips.Add(new AudioObject("runsteps", "runsteps"));
		audioClips.Add(new AudioObject("HeartBeat", "HeartBeat"));
		audioClips.Add(new AudioObject("Ice", "Ice"));

		//Lore audio
		audioClips.Add(new AudioObject("lore1", "lore1"));
		/*
		audioClips.Add(new AudioObject("lore2", "lore2"));
		audioClips.Add(new AudioObject("lore3", "lore3"));
		audioClips.Add(new AudioObject("lore4", "lore4"));
		audioClips.Add(new AudioObject("lore5", "lore5"));
		audioClips.Add(new AudioObject("lore6", "lore6"));
		audioClips.Add(new AudioObject("lore7", "lore7"));
		audioClips.Add(new AudioObject("lore8", "lore8"));
		*/
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
		if(Save.playPoison == true){
			PlaySoundTwo ("HeartBeat");
			Save.playPoison = false;
		}
		if(Save.playIce == true){
			PlaySoundTwo ("Ice");
			Save.playIce = false;
		}
		if(Save.playFootsteps == true){
			PlaySoundFootsteps ();
			Save.playFootsteps = false;
		}
		if(Save.stopFootsteps == true){
			audioSourceFootsteps.Stop ();
			Save.stopFootsteps = false;
		}
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
		if(Save.teleportSound == true){
			PlaySoundOne ("teleport");
			Save.teleportSound = false;
		}
		if(Save.playLore1 == true){
			PlaySoundTwo ("lore1");
			Save.playLore1 = false;
		}
		if(Save.playLore2 == true){
			PlaySoundTwo ("lore2");
			Save.playLore2 = false;
		}
		if(Save.playLore3 == true){
			PlaySoundTwo ("lore3");
			Save.playLore3 = false;
		}
		if(Save.playLore4 == true){
			PlaySoundTwo ("lore4");
			Save.playLore4 = false;
		}
		if(Save.playLore5 == true){
			PlaySoundTwo ("lore5");
			Save.playLore5 = false;
		}
		if(Save.playLore6 == true){
			PlaySoundTwo ("lore6");
			Save.playLore6 = false;
		}
		if(Save.playLore7 == true){
			PlaySoundTwo ("lore7");
			Save.playLore7 = false;
		}
		if(Save.playLore8 == true){
			PlaySoundTwo ("lore8");
			Save.playLore8 = false;
		}
		if(Save.stopLore == true){
			audioSourceTwo.Stop ();
			Save.stopLore = false;
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
	public void PlaySoundFootsteps(){
		audioSourceFootsteps.clip = getAudioClip("runsteps");
		audioSourceFootsteps.Play ();
	}
	// Used for Lore playback
	public void PlaySoundTwo(string name){
		foreach (AudioObject item in audioClips) {
			if(item.clipName == name){
				audioSourceTwo.clip = item.audioClip;
				StartCoroutine (loreCoroutine());
			}
		}
	}
	public IEnumerator loreCoroutine(){
		audioSourceTwo.Play ();
		yield return new WaitForSeconds (getAudioClip (audioSourceTwo.clip.name).length + 1);
		Lore.loreAudioPanel.gameObject.SetActive (false);
	}
}
