﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestorePurchaseButton : MonoBehaviour {

	// Use this for initialization
	void Start () {

        if (Application.platform == RuntimePlatform.Android)
        { gameObject.SetActive(false); }


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
