using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultScreen_ButtonShake : MonoBehaviour {
   
    public float amplitude;          //Set in Inspector 
    public float speed;                  //Set in Inspector 
    private float tempVal;
    private Vector3 tempPos;

    public float wiggleTime;
    private float OGwiggleTime;

    public float timeLeft ;
    private float OGtimeLeft;

    private bool isCounting = false;
    void Start()
    {
        tempVal = transform.position.x;
    }

    void Update()
    {
        if(isCounting == true)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {

                if (wiggleTime > 0)
                {
                    tempPos.y = transform.position.y;
                    tempPos.x = tempVal + amplitude * Mathf.Sin(speed * Time.time);
                    tempPos.z = transform.position.z;
                    transform.position = tempPos;
                    wiggleTime -= Time.deltaTime;
                }
                    else
                    {
                    isCounting = false;    
                    }
            }   
        }
    }


    public void ResetCounter(float NewTime)
    {
        timeLeft = NewTime;
        wiggleTime = 2;
        isCounting = true;
    }
}
