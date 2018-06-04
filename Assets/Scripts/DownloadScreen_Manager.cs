using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownloadScreen_Manager : MonoBehaviour {

    private GameObject SelecedStickerRef;
    public Transform Clone_Position;
    private GameObject Instance;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CloneSelection()
    {
        SelecedStickerRef = GameObject.FindGameObjectWithTag("ClonedSticker");
        Instance = Instantiate(SelecedStickerRef, Clone_Position.position, SelecedStickerRef.transform.rotation);
        Destroy(SelecedStickerRef);
        Instance.transform.SetParent(gameObject.transform,false);// = gameObject.transform;
        Instance.transform.position = Clone_Position.position;
        Instance.tag = "SelectedSticker";
    }

    public void CloneKiller()
    {
       Destroy(Instance);
    }
}
