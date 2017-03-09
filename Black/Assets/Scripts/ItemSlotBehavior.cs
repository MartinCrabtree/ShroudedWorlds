using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemSlotBehavior : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler {

    public Item item;
    Image itemImage;

	// Use this for initialization
	void Start () {
        itemImage = gameObject.transform.GetChild(0).GetComponent<Image>();
		
	}
	
	// Update is called once per frame
	void Update () {
        if(item != null)
        {
            itemImage.enabled = true;
            itemImage.sprite = item.itemIcon;
        }

        else
        {
            itemImage.enabled = false;
        }
		
	}
    


    // event handlers /////
    public void OnPointerDown(PointerEventData data)
    {

    }

    public void OnPointerEnter(PointerEventData data)
    {

    }
}
