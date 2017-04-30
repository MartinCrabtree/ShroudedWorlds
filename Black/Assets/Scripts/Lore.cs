using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lore : MonoBehaviour {
	public static Button loreAudioButton;
	public static GameObject loreAudioPanel;
	public static Text loreAudioText;
	
	public class LoreItem{
		public string loreText;
//		public string lorePicture;
		public string loreName;
		public bool locked;

		//public LoreItem(string newText, string newImage, string newName){
		public LoreItem(string newText, string newName){
			loreText = newText;
//			lorePicture = newImage;
			loreName = newName;
			locked = true;
		}
	}
	void Awake(){
		loreAudioPanel = GameObject.Find ("/Canvas/LoreAudio");
		loreAudioButton = GameObject.Find ("/Canvas/LoreAudio/Button").GetComponent<Button>();
		loreAudioText = GameObject.Find ("/Canvas/LoreAudio/Text").GetComponent<Text>(); 
		loreAudioPanel.gameObject.SetActive (false);
		loreAudioButton.onClick.AddListener (stopLore);

		//FREDRIK Create
		Save.lore.Add(new LoreItem("The truth is I never truly saw other humans as peers, even less as equals. For my unrivalled magical prowess I was awarded envy, fear, and reverence, all in equal measure. I was only truly hated for my intellect, and the success it brought me. My generosity counted for little, in spite of the countless boons I awarded my fellow humans. I only ever intended to leave the world a better place than I found it. In order to achieve that, I did what no one else could have done. I sought and found power that surpassed even that of the gods! The pride I felt... as I gave that power to my kind, as I elevated them. \n\nWhat a fool I was.\n\nMy name is Tollun'Gar, and I am the man who set the world on fire.", "page1"));
		Save.lore.Add(new LoreItem("We created such wonders! With our newfound power we ushered in a new age, a renaissance of magical innovation! Cultural variety blossomed and boomed, as we found a way to connect faraway places through a system of portals. With travel instantaneous we were worshipped, at least at first. Small wonder, as we brought an end to hunger and crushed all instigators of violence. Surprisingly, war lost its appeal once everyone had plenty to eat.\nAh, the cities we built once we bonded together like never before in human history! The art we created, and the food we enjoyed! Wine, music, dance, and theatre! We wanted to live forever…\n\nand that is when the Reaping began. We returned to our former brutality with renewed bloodlust. Many had to die so that the few could live, so that we could cheat death long enough to escape her clutches forever.", "page2"));
		Save.lore.Add(new LoreItem("I have decided to hire a trap maker. It has become necessary after yesterday's trouble. Unwanted rabble came knocking on the entrance to my sanctum, which I apparently had not done a good enough job hiding. The filth even broke down my door! They did not stand a chance against the mighty Tollun'Gar! Ha ha! I made swift work of them. I suppose it is fortunate that my old apprentice is long dead, otherwise I would never have heard the end of it. He never did kindly to \"indiscriminate murder\" as he put it. Fool claimed it was counterproductive. Yes, I will hire the best trap maker in the world and build the best defence money can buy! I am also considering hiring builders for a wall outside my sanctum. If I build it high enough that should keep the riffraff out.", "page3"));
		Save.lore.Add(new LoreItem("The construction is complete! The trap maker demanded an outrageous sum, but he did a fine job I must admit. I leant him some of my extraordinary power for the spell-protection. Nothing should be able to break through those enchantments on the doors! Well, nothing except perhaps myself! Ha Ha Ha! It is a good thing I acquired the recipe for the antidote… that poison would be a headache to deal with if I ever forgot about the trap. I have also acquired mushrooms, quite rare specimens at that! I had wanted to fashion an elixir out of them but they melted the cast iron cauldron, even though I had enchanted it. Truly quite remarkable! I must remember to find a way to store them safely since they can do a number even on magically enhanced metal.", "page4"));
		Save.lore.Add(new LoreItem("I expected so much better from my peers. They were scholars! How could they not know better? Such talent, corrupted by insidious purpose and greed. I never imagined they could do something so unspeakable. Two million people, gone, disintegrated in an instant. I have asked myself why I could not see such a fatal flaw in my design ever since it happened. The portals must be shut down, I see that now. I will not have my hands stained with more blood. I will take back every single gift I ever gave them, I must. Afterwards, I will go into seclusion. No longer will my genius fuel the engines of war. ", "page5"));
		Save.lore.Add(new LoreItem("I have counted two-hundred days since I entered seclusion. I failed the task I set out to achieve. This sensation is perturbing, I never knew failure could be so haunting. The portals are no more, I managed to dismantle two of them but the other thirty-nine… the world will never be the same. When I first created the portals Alia Tentras warned me what could happen. She knew how unstable that kind of magic could be. I can still hear her voice, or perhaps the voice is my own, or perhaps I am going insane in my isolation. Perhaps this curse is actually a blessing… I cannot be hated for my legacy, the loss of life, and the destruction my creations have wrought, if there is no one left that remembers. Ah, this morbid relief perplexes me! Even if they survived the explosions, they will not survive the aftermath.", "page6"));
		Save.lore.Add(new LoreItem("Alia Tentras was a phenomenal mage, truly. Out of the many, it was only she who could comprehend the full extent of my genius. My greatest sin was not that I ignored the many warnings she gave me along the way toward ruin. I cannot count how many times she told me what my ambition would mean for the world. No, my greatest sin... I would do it all over again. No price was too high, no price would ever be too high, except the one we are currently paying.\n\nThe fault lies not with me! Humans are corrupt by their very nature! They could not handle the gift I bestowed upon them. THEY brought the world to its knees, not I!", "page7"));
		Save.lore.Add(new LoreItem("If there, against all, odds is a world for my legacy to survive into, I would offer a few words for posterity. I will never apologize for what I did, even in hindsight. The things I did, and everything I built... it had to be me! Anyone else would have gotten it wrong. Throughout the millennium of my existence I have learned but one humbling lesson. The world will always strive toward equilibrium, and when you break it the retribution is swift and brutal. I write these words knowing my final moment draws near. I have not eaten in four days and I am running out of water.\n\nPerhaps there is a lesson to be learned in my passing, but if there is I do not see it. I would never have guessed that the great Tollun'Gar would meet such an end. Why did I forget the cursed key and the activation sequence in the library? I have tried everything I can think of aside from blasting my way out to the surface through the mountain bedrock. I would rather starve to death than have my insides boiled by volatile magic.\n\nWell, at least the trap maker lived up to his reputation. I only hire the best.", "page8"));

	}
	public static void loreUpdate(string name){
		foreach (Lore.LoreItem item in Save.lore) {
			if(item.loreName == name){
				item.locked = false;
				//Play scribble sound
				Save.journalscribble = true;
				//Play lore entry by lore
				playLore(name);
				Debug.Log (item.loreName + " locked status is now " + item.locked);
			}
			Debug.Log (item.loreName + " locked status is now " + item.locked);
		}
//		Debug.Log ("Save.JournalScribble is: " + Save.journalscribble);
	}
	public static void playLore (string name){
		loreAudioPanel.gameObject.SetActive (true);
		if (name == "page1") {
			loreAudioText.text = "Lore Page 1 Playing";
			Save.playLore1 = true;
		} else if (name == "page2") {
			loreAudioText.text = "Lore Page 2 Playing";
			Save.playLore2 = true;
		} else if (name == "page3") {
			loreAudioText.text = "Lore Page 3 Playing";
			Save.playLore3 = true;
		} else if (name == "page4") {
			loreAudioText.text = "Lore Page 4 Playing";
			Save.playLore4 = true;
		} else if (name == "page5") {
			loreAudioText.text = "Lore Page 5 Playing";
			Save.playLore5 = true;
		} else if (name == "page6") {
			loreAudioText.text = "Lore Page 6 Playing";
			Save.playLore6 = true;
		} else if (name == "page7") {
			loreAudioText.text = "Lore Page 7 Playing";
			Save.playLore7 = true;
		} else if (name == "page8") {
			loreAudioText.text = "Lore Page 8 Playing";
			Save.playLore8 = true;
		}
	}
	public static void stopLore (){
		loreAudioPanel.gameObject.SetActive (false);
		Save.stopLore = true;
	}
}
