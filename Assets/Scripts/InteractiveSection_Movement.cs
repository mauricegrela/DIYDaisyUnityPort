using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class InteractiveSection_Movement : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isOver = false;
    public GameObject GMRef;
    public int Inverter;
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse enter");
        isOver = true;
        GMRef.GetComponent<InteractiveSection_Manager>().isMoving = true;
        GMRef.GetComponent<InteractiveSection_Manager>().inverter =Inverter;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse exit");
        isOver = false;
        GMRef.GetComponent<InteractiveSection_Manager>().isMoving = false;
    }
}
