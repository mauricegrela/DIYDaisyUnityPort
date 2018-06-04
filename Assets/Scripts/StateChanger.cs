using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StateChange(string SelectedCharacter)
    {
        foreach (Transform child in transform)
        {
            if(child.gameObject.name != SelectedCharacter)
            {
            child.gameObject.SetActive(false);
            }
                else
                {
                child.gameObject.SetActive(true);
                }
            //child.gameObject.GetComponent<Button>().interactable = true;
            //Debug.Log(child.gameObject.GetComponent<Button>().enabled);
        }
    }
}
