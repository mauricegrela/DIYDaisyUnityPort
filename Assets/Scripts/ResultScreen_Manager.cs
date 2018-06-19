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
    private float scaleSetter = 1;
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
        Instance.transform.localScale = new Vector3(scaleSetter, scaleSetter, scaleSetter);
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


        if (Instance != null)
        {
            Destroy(Instance);
        }

        SelecedStickerRef = GameObject.FindGameObjectWithTag("SelectedSticker");
        if (SelecedStickerRef != null)
        {
            Destroy(SelecedStickerRef);
        }

    }

    // Update is called once per frame
    void Update () {
		
	}

    public void ScaleAdjustment(float Adjustment)
    {
        scaleSetter = Adjustment;
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
