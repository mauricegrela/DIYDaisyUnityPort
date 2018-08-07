using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PDFDownloadScript : MonoBehaviour {

    private float countDownTimer = 1;
    private bool isCounting = false;
    public GameObject ScrollView;
    public GameObject BTN1;
    public GameObject BTN2;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isCounting == true)
        {
            countDownTimer -= Time.deltaTime;
            if (countDownTimer <= 0)
            {
                resetDownload();
            }
        }
    }

    public void LaunchDelay()
    {
        isCounting = true;
        countDownTimer = 1;
    }

    public void resetDownload()
    {
        isCounting = false;
        countDownTimer = 1;
        BTN1.SetActive(true);
        BTN2.SetActive(true);
        ScrollView.SetActive(false);
        gameObject.SetActive(false);
    }

}
