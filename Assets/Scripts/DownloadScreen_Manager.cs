using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DownloadScreen_Manager : MonoBehaviour {

    private GameObject SelecedStickerRef;
    public Transform Clone_Position;
    public GameObject ResultScreenRef;
    public GameObject BackButtonResults;
    private GameObject Instance;

    [SerializeField] GameObject WhiteInstance;
    private bool isFadding = false;
    public Color lerpedColor;
    private float PingPongFloat;

    private float countDownTimer = 1;
    private bool isCounting = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        //lerpedColor = Color.Lerp(Color.white, lerpedColor, Mathf.PingPong(Time.time, 1));


        if(isCounting == true)
        {
            PingPongFloat +=Time.deltaTime;
            WhiteInstance.GetComponent<Image>().color = Color.Lerp(Color.white, lerpedColor, PingPongFloat);
            countDownTimer -= Time.deltaTime;  
            if(countDownTimer<=0)
            {
                resetDownload();
            }
        }
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

    public void resetDownload()
    {
        isCounting = false;
        countDownTimer = 1;
        ResultScreenRef.SetActive(true);
        BackButtonResults.SetActive(true);
        WhiteInstance.SetActive(false);
        WhiteInstance.GetComponent<Image>().color = Color.white;
        PingPongFloat = 0;
        ResultScreenRef.GetComponent<ResultScreen_Manager>().CloneSelection();
        CloneKiller();
        gameObject.SetActive(false);
    }

    public void LaunchDelay()
    {
        isCounting = true;
        countDownTimer = 1;
    }

    public void CloneKiller()
    {
       Destroy(Instance);
    }

    public void WhiteFlash()
    {
        
    }
}
