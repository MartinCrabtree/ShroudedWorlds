using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bed : MonoBehaviour {
	public static Text journalUpdated;

	void Awake(){
		journalUpdated = GameObject.Find ("/Canvas/Text/JournalUpdated").GetComponent<Text>();
	}
	// FREDRIK UPDATE THIS
	void OnMouseDown(){
		displayJournalText();
		Lore.loreUpdate ("bed");
	}

	// Have to put some journal stuff here because startcoroutine is not static
	public void displayJournalText (){
		journalUpdated.text = "Journal Updated";
		StartCoroutine(FadeTextToZeroAlpha(2f, journalUpdated));
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
	/*
	public IEnumerator FadeTextToFullAlpha(float t, Text i)
	{
		i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
		while (i.color.a < 1.0f)
		{
			i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
			yield return null;
		}
	}
	*/
}
