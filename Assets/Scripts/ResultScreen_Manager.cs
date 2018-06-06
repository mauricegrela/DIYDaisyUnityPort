using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ResultScreen_Manager : MonoBehaviour {
    private GameObject SelecedStickerRef;
    public Transform Clone_Position;
    public Transform Interactive;
    private GameObject Instance;
    // Use this for initialization
    void Start () {
        
    }

    public void CloneSelection()
    {

        SelecedStickerRef = GameObject.FindGameObjectWithTag("SelectedSticker");
        Instance = Instantiate(SelecedStickerRef, Clone_Position.position, SelecedStickerRef.transform.rotation);
        //Instance.transform.SetParent(gameObject.transform);// = gameObject.transform;
        Instance.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        Instance.transform.position = Clone_Position.position;
        Instance.transform.SetParent(gameObject.transform, true);// = gameObject.transform;
        Instance.tag = "ClonedSticker";
    }


    public void InteractiveCloneSelection()
    {
        SelecedStickerRef = GameObject.FindGameObjectWithTag("ClonedSticker");
        Instance = Instantiate(SelecedStickerRef, Clone_Position.position, SelecedStickerRef.transform.rotation);
        Instance.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
        Instance.transform.position = Clone_Position.position;
        Instance.transform.SetParent(Interactive.transform, true);// = gameObject.transform;
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
}
