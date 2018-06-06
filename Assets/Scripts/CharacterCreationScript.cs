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
    private Sprite BodySpriteRef;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(isClickDragging == true)
        {
            SelectedSticker.transform.position = Input.mousePosition;
            //SelectedSticker.position.x= Input.mousePosition.x;
            // SelectedStickerposition.y  = Input.mousePosition.y;
        }
	}


    public void DeactivateCharacter()
    {

        if (CurrentCharacter != null)
        {//Clear the previous sticker and remove all selected 
            GameObject SelectedObject;
            SelectedObject = GameObject.FindGameObjectWithTag("SelectedSticker");

            for (int i =0; i< CurrentCharacter.GetComponent<CharacterDataStorage>().StickerSets.Length;i++)
            {

                foreach (Transform child in CurrentCharacter.GetComponent<CharacterDataStorage>().StickerSets[i].transform)
                {
                    child.gameObject.GetComponent<Button>().interactable = true;
                }

                if (CurrentCharacter.GetComponent<CharacterDataStorage>().StickerSets[i].gameObject.name != "Sticker Set One")
                { 
                CurrentCharacter.GetComponent<CharacterDataStorage>().StickerSets[i].SetActive(false);
                }
                    else
                    {
                    CurrentCharacter.GetComponent<CharacterDataStorage>().StickerSets[i].SetActive(true);
                    }
            }
            

            foreach (Transform child in SelectedObject.transform)
            {
                if (child.gameObject.name == "Body")
                {
                    BodySpriteRef = child.gameObject.GetComponent<Image>().sprite;
                }
            }

            foreach (Transform child in SelectedObject.transform)
            {
                child.gameObject.GetComponent<Image>().sprite = BodySpriteRef;
            }

            SelectedObject.gameObject.tag = "Untagged";
            CurrentCharacter.gameObject.SetActive(false);
        }
        CurrentCharacter = null;
    }

        public void ActivateCharacter(GameObject SelectedCharacter)
    {
            if(CurrentCharacter != null)
            {//Clear the previous sticker and remove all selected 
            GameObject SelectedObject;

            for (int i = 0; i < CurrentCharacter.GetComponent<CharacterDataStorage>().StickerSets.Length; i++)
            {
                                foreach (Transform child in CurrentCharacter.GetComponent<CharacterDataStorage>().StickerSets[i].transform)
                {
                    child.gameObject.GetComponent<Button>().interactable = true;
                }

                if (CurrentCharacter.GetComponent<CharacterDataStorage>().StickerSets[i].gameObject.name != "Sticker Set One")
                {
                    CurrentCharacter.GetComponent<CharacterDataStorage>().StickerSets[i].SetActive(false);
                }
                    else
                    {
                        CurrentCharacter.GetComponent<CharacterDataStorage>().StickerSets[i].SetActive(true);
                    }
            }

            SelectedObject = GameObject.FindGameObjectWithTag("SelectedSticker");
                foreach (Transform child in SelectedObject.transform)
                {
                    if(child.gameObject.name == "Body")
                    {
                    BodySpriteRef = child.gameObject.GetComponent<Image>().sprite;
                    }
                }

            foreach (Transform child in SelectedObject.transform)
            {
                child.gameObject.GetComponent<Image>().sprite = BodySpriteRef;
            }

            SelectedObject.gameObject.tag = "Untagged";
            if(CurrentCharacter != SelectedCharacter)
            {
                CurrentCharacter.gameObject.SetActive(false);
            }
            
        }
        CurrentCharacter = SelectedCharacter;
        StickerSetCounter = 0;
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
            //child.gameObject.GetComponent<Button>().interactable = true;
            child.gameObject.GetComponent<Image>().color = Color.white;
        }

    }

    public void CharacterClickAndDragEnd()
    {
        isClickDragging = false;
    }

    public void ChangeLevel(string Level)
    {
        
    }

    }
