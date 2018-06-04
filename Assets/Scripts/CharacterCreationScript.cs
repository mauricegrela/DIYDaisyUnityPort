using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CharacterCreationScript : MonoBehaviour {

    private GameObject CurrentCharacter;
 
    private int StickerSetCounter;//T
    //Click And Drag Variables
    private bool isClickDragging;
    private Transform SelectedSticker;
    private Vector3 offset;
    public GameObject Test;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(isClickDragging == true)
        {

            //SelectedSticker.position.x= Input.mousePosition.x;
           // SelectedStickerposition.y  = Input.mousePosition.y;
        }
	}

    void OnMouseDown()
    {
        if (isClickDragging == true)
        {
        offset = SelectedSticker.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
        }
    }

    void OnMouseDrag()
    {
        if (isClickDragging == true)
        {
            Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
            SelectedSticker.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
        }
    }

    public void ActivateCharacter(GameObject SelectedCharacter)
    {       
        CurrentCharacter = SelectedCharacter;
        StickerSetCounter = 0;
        //CurrentCharacter.GetComponent<CharacterDataStorage>().StickerCollection.gameObject.tag = "SelectedSticker";
    }

    public void NextCounter()
    {
    CurrentCharacter.GetComponent<CharacterDataStorage>().StickerSets[StickerSetCounter].SetActive(false);
        if(StickerSetCounter < CurrentCharacter.GetComponent<CharacterDataStorage>().StickerSets.Length-1)
        {
        StickerSetCounter++;
        }
            else
            {
            StickerSetCounter = 0;
            }
    CurrentCharacter.GetComponent<CharacterDataStorage>().StickerSets[StickerSetCounter].SetActive(true);
    }

    public void PreviousCounter()
    {
        CurrentCharacter.GetComponent<CharacterDataStorage>().StickerSets[StickerSetCounter].SetActive(false);
        if (StickerSetCounter >0)
        {
            StickerSetCounter--;
        }
        else
        {
            StickerSetCounter = CurrentCharacter.GetComponent<CharacterDataStorage>().StickerSets.Length-1;
        }
        CurrentCharacter.GetComponent<CharacterDataStorage>().StickerSets[StickerSetCounter].SetActive(true);
    }

    public void CharacterClickAndDrag(Transform TargetSticker)
    {
        isClickDragging = true;
        SelectedSticker = TargetSticker;
        foreach (Transform child in CurrentCharacter.GetComponent<CharacterDataStorage>().StickerSets[StickerSetCounter].transform)
        {
            child.gameObject.GetComponent<Button>().interactable = true;
            //Debug.Log(child.gameObject.GetComponent<Button>().enabled);
        }
        //CurrentCharacter.GetComponent<CharacterDataStorage>().StickerSets[StickerSetCounter].SetActive(true);
    }

    public void ChangeLevel(string Level)
    {
        
    }

    }
