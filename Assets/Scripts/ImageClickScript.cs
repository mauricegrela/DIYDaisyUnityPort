using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems; // Required when using Event data.

public class ImageClickScript : MonoBehaviour, IPointerUpHandler, IPointerDownHandler // required interface when using the OnPointerDown method.
{
    public GameObject CharacterSheet;
    public CharacterCreationScript ClickDragScriptRef;
    public Color Sellected;
    public Sprite SpriteToSet;
    public RectTransform BodyLocation;

    public void OnPointerDown(PointerEventData eventData)
    {
        CharacterSheet.GetComponent<Image>().enabled = true;
        ClickDragScriptRef.CharacterClickAndDrag(CharacterSheet.GetComponent<RectTransform>());
        CharacterSheet.GetComponent<Image>().sprite = SpriteToSet;
        GetComponent<Image>().color = Sellected;
        //Debug.Log("PointerDown");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
    //Debug.Log("PointerUp");
    ClickDragScriptRef.CharacterClickAndDragEnd();
    CharacterSheet.GetComponent<RectTransform>().position = BodyLocation.position;

    }
}
