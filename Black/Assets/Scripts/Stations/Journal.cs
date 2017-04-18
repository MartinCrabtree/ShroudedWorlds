using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Journal : MonoBehaviour {

	public static int unlockedPage;
	public static int pageNumberLeft;
	public static int pageNumberRight;
	public static GameObject panelLock;
	public static GameObject leftPage;
	public static GameObject rightPage;
	public static GameObject leftPanelLock;
	public static GameObject rightPanelLock;
	public static Text leftText;
	public static Text rightText;
	public static Image leftImage;
	public static Image rightImage;
	public static Button arrowRight;
	public static Button arrowLeft;
	public static Button close;
//	public Button journalStation;

	void Awake (){
		panelLock = GameObject.Find ("/Canvas/UILockPanel");
		leftPage = GameObject.Find ("/Canvas/UILockPanel/Journal/leftpage");
		rightPage = GameObject.Find ("/Canvas/UILockPanel/Journal/rightpage");
		leftPanelLock = GameObject.Find ("/Canvas/UILockPanel/Journal/leftlockedpanel");
		rightPanelLock = GameObject.Find ("/Canvas/UILockPanel/Journal/rightlockedpanel");
		leftText = GameObject.Find ("/Canvas/UILockPanel/Journal/leftpage/textleftpage").GetComponent<Text>();
		rightText = GameObject.Find ("/Canvas/UILockPanel/Journal/rightpage/textrightpage").GetComponent<Text>();
		leftImage = GameObject.Find ("/Canvas/UILockPanel/Journal/leftpage/leftimage").GetComponent<Image>();
		rightImage = GameObject.Find ("/Canvas/UILockPanel/Journal/rightpage/rightimage").GetComponent<Image>();

		arrowRight = GameObject.Find ("/Canvas/UILockPanel/Journal/arrowright").GetComponent<Button>();
		arrowLeft = GameObject.Find ("/Canvas/UILockPanel/Journal/arrowleft").GetComponent<Button>();
		close = GameObject.Find ("/Canvas/UILockPanel/Journal/closebutton").GetComponent<Button>();
		// REPLACE WITH THE JOURNAL OBJECT IN ROOM
	//	journalStation = GameObject.Find ("/Canvas/Tempbutton").GetComponent<Button>();
	}
	// Use this for initialization
	void Start () {
		arrowLeft.onClick.AddListener (leftClick);
		arrowRight.onClick.AddListener (rightClick);
		close.onClick.AddListener (closeJournal);
//		journalStation.onClick.AddListener (openJournal);

		// Set up lore 1 and 2 as initial journal open pages
		pageProcessing(0,1);

		panelLock.SetActive (false);
	}
	public static void pageProcessing(int left, int right){
		pageNumberLeft = left;
		pageNumberRight = right;

		leftImage.sprite = Resources.Load<Sprite> (Save.lore [left].lorePicture);
		leftText.text = Save.lore [left].loreText;
		rightImage.sprite = Resources.Load<Sprite> (Save.lore [right].lorePicture);
		rightText.text = Save.lore [right].loreText;

		if (Save.lore [left].locked == false) {
			leftPanelLock.gameObject.SetActive (false);
			leftPage.gameObject.SetActive (true);
		} else {
			leftPanelLock.gameObject.SetActive (true);
			leftPage.gameObject.SetActive (false);			
		}
		if (Save.lore [right].locked == false) {
			rightPanelLock.gameObject.SetActive (false);
			rightPage.gameObject.SetActive (true);
		} else {
			rightPanelLock.gameObject.SetActive (true);
			rightPage.gameObject.SetActive (false);
		}		
	}
	public void leftClick(){
		if (pageNumberLeft == 0) {
			Debug.Log ("already at first page");
		} else {
			pageProcessing (pageNumberLeft-2,pageNumberRight-2);
//			Debug.Log ("pageNumberLeft: " + pageNumberLeft);
//			Debug.Log ("pageNumberRight: " + pageNumberRight);
		}
	}
	public void rightClick(){
		if (pageNumberRight == Save.lore.Count-1) {
			Debug.Log ("already at end page");
		} else {
			pageProcessing (pageNumberLeft + 2, pageNumberRight + 2);
//			Debug.Log ("pageNumberLeft: " + pageNumberLeft);
//			Debug.Log ("pageNumberRight: " + pageNumberRight);
		}
	}
	public void closeJournal(){
		panelLock.gameObject.SetActive (false);
	}
	public static void openJournal(){
		panelLock.gameObject.SetActive (true);
		pageProcessing (0, 1);
//		rightImage.sprite = Resources.Load<Sprite> (Save.lore [0].lorePicture);
//		Debug.Log (Save.lore[1].lorePicture);
	}
}
