using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Scaler : MonoBehaviour {

    private CanvasScaler ScaleRef;
	// Use this for initialization
	void Start () {
        
        ScaleRef = GetComponent<CanvasScaler>();

        if ((UnityEngine.iOS.Device.generation.ToString()).IndexOf("iPad") > -1)
        {
            ScaleRef.matchWidthOrHeight = 0;
        }


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
