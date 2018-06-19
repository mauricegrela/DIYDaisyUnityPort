using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class INI_WorkAround : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SceneManager.LoadScene("CraftScreen", LoadSceneMode.Single);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
