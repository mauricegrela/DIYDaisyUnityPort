using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactive_Boarder : MonoBehaviour {


    public bool isLeft;
    public GameObject ManagerRef;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if(isLeft == true)
        {
            Debug.Log("Collision Left");
            ManagerRef.GetComponent<InteractiveSection_Manager>().BoarderRight(); 
        }
            else
            {
            Debug.Log("Collision Right");
            ManagerRef.GetComponent<InteractiveSection_Manager>().BoarderLeft();
            }
    }
}
