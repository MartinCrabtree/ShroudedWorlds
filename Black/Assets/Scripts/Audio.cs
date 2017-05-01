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
	public AudioSource audioSourceThree;
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
		audioClips.Add(new AudioObject("lore1", "Lore_Page_1"));
		audioClips.Add(new AudioObject("lore2", "Lore_Page_2"));
		audioClips.Add(new AudioObject("lore3", "Lore_Page_3"));
		audioClips.Add(new AudioObject("lore4", "Lore_Page_4"));
		audioClips.Add(new AudioObject("lore5", "Lore_Page_5"));
		audioClips.Add(new AudioObject("lore6", "Lore_Page_6"));
		audioClips.Add(new AudioObject("lore7", "Lore_Page_7"));
		audioClips.Add(new AudioObject("lore8", "Lore_Page_8"));
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
		/*
		if(audioSourceThree.isPlaying != true){
			Lore.loreAudioPanel.gameObject.SetActive (false);	
		}
		*/
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
			PlaySoundThree ("lore1");
			Save.playLore1 = false;
		}
		if(Save.playLore2 == true){
//			Lore.loreAudioPanel.gameObject.SetActive (false);
			PlaySoundThree ("lore2");
			Save.playLore2 = false;
		}
		if(Save.playLore3 == true){
//			Lore.loreAudioPanel.gameObject.SetActive (false);
			PlaySoundThree ("lore3");
			Save.playLore3 = false;
		}
		if(Save.playLore4 == true){
			PlaySoundThree ("lore4");
			Save.playLore4 = false;
		}
		if(Save.playLore5 == true){
			PlaySoundThree ("lore5");
			Save.playLore5 = false;
		}
		if(Save.playLore6 == true){
			PlaySoundThree ("lore6");
			Save.playLore6 = false;
		}
		if(Save.playLore7 == true){
			PlaySoundThree ("lore7");
			Save.playLore7 = false;
		}
		if(Save.playLore8 == true){
			PlaySoundThree ("lore8");
			Save.playLore8 = false;
		}
		if(Save.stopLore == true){
			audioSourceThree.Stop ();
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

	public void PlaySoundTwo(string name){
		foreach (AudioObject item in audioClips) {
			if(item.clipName == name){
				audioSourceTwo.clip = item.audioClip;
				audioSourceTwo.Play ();
			}
		}
	}
	// Used for Lore playback
	public void PlaySoundThree(string name){
		foreach (AudioObject item in audioClips) {
			if(item.clipName == name){
				audioSourceThree.clip = item.audioClip;
				StartCoroutine (loreCoroutine());
			}
		}
	}
	public IEnumerator loreCoroutine(){
		audioSourceThree.Play ();
		yield return new WaitForSeconds (getAudioClip (audioSourceThree.clip.name).length + 1);
/*
		if(audioSourceThree.isPlaying != true){
			Lore.loreAudioPanel.gameObject.SetActive (false);	
		}*/
		Lore.loreAudioPanel.gameObject.SetActive (false);
	}
}
