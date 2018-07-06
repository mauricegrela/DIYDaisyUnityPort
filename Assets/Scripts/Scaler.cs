using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Scaler : MonoBehaviour
{

    private CanvasScaler ScaleRef;
    // Use this for initialization
    void Start()
    {

        ScaleRef = GetComponent<CanvasScaler>();
#if UNITY_ANDROID    // Cap letters
        float screenHeightInInch = Screen.height / Screen.dpi;
        if (screenHeightInInch < 3.1)
        {
           
        }
        else
        {
        ScaleRef.matchWidthOrHeight = 0;
        }
#else

        if ((UnityEngine.iOS.Device.generation.ToString()).IndexOf("iPad") > -1)
        {
            ScaleRef.matchWidthOrHeight = 0;
        }
#endif

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
