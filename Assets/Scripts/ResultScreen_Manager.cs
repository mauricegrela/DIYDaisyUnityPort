using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ResultScreen_Manager : MonoBehaviour {
    private GameObject SelecedStickerRef;
    public Transform Clone_Position;
    public Transform Interactive;
    private GameObject Instance;
    public Transform ParentRef;
    // Use this for initialization
    void Start () {
        
    }

    public void CloneSelection()
    {

        SelecedStickerRef = GameObject.FindGameObjectWithTag("SelectedSticker");
        Instance = Instantiate(SelecedStickerRef, Clone_Position.position, SelecedStickerRef.transform.rotation);
        //Instance.transform.SetParent(gameObject.transform);// = gameObject.transform;
        Instance.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
        Instance.transform.SetParent(gameObject.transform, false);// = gameObject.transform;
        Instance.transform.position = Clone_Position.position;
        Instance.tag = "ClonedSticker";
    }

    public void DeactivateCharacterFromResult()
    {
        GameObject SelectedObject;
        SelectedObject = GameObject.FindGameObjectWithTag("ClonedSticker");
        Destroy(SelectedObject);
    }



    public void InteractiveCloneSelection()
    {
        SelecedStickerRef = GameObject.FindGameObjectWithTag("ClonedSticker");
        Instance = Instantiate(SelecedStickerRef, Clone_Position.position, SelecedStickerRef.transform.rotation);
        Instance.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
        Instance.transform.SetParent(ParentRef.transform, false);// = gameObject.transform;
        Instance.transform.position = Clone_Position.position;
        Interactive.GetComponent<InteractiveSection_Manager>().InteraciveClone = Instance;
        //Destroy(SelecedStickerRef);
    }

    public void CloneKiller()
    {
        SelecedStickerRef = GameObject.FindGameObjectWithTag("ClonedSticker");
        
        if (SelecedStickerRef != null)
        {
        Destroy(SelecedStickerRef);
        }

        SelecedStickerRef = GameObject.FindGameObjectWithTag("SelectedSticker");
        if (Instance != null)
        {
            Destroy(Instance);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void CloneToggle(bool Setting)
    {
        //GameObject ClonedSticker;

        if(Instance != null)
        {
        Instance.SetActive(Setting); 
        }
            else
            {
            Instance = GameObject.FindGameObjectWithTag("ClonedSticker"); 
            Instance.SetActive(Setting);
            }
    }
}
