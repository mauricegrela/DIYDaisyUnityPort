using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

using UnityEngine;

public class InteractiveSection_Manager : MonoBehaviour {

    public RectTransform[] canvas;
    RectTransform button;
    Vector3 startingPosition;
    public float speed;
    public bool isMoving = false;
    public int inverter = 1;
    public GameObject InteraciveClone;

    private RectTransform rectTransform
    {
        get
        {
            return transform as RectTransform;
        }
    }

    void Start()
    {
        button = gameObject.GetComponent<RectTransform>();
        //canvas = GameObject.Find("Canvas").GetComponent<RectTransform>();
        startingPosition = transform.position;
        speed = -10f;
    }

    void Update()
    {
        if(isMoving == true)
        {
            //float offset = (Time.time * speed)*inverter;
            //canvas[0].GetComponent<Image>().material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
            InteraciveClone.transform.rotation = Quaternion.Euler(0, 0, -45 * inverter);
            if (canvas[0].transform.position.x >= 2830)
            {
                for (int i = 0; i < canvas.Length; i++)
                {
                    canvas[i].transform.position = new Vector2(canvas[i].transform.position.x- 5240, canvas[i].transform.position.y);
                }
            }
            if (canvas[0].transform.position.x <= -1800)
            {
                for (int i = 0; i < canvas.Length; i++)
                {
                   canvas[i].transform.position = new Vector2(canvas[i].transform.position.x + 5240, canvas[i].transform.position.y);
                }
            }

            for (int i = 0; i < canvas.Length; i++)
            {
                canvas[i].transform.Translate(speed * inverter, 0f, 0f);
            }
        }
        else
        {
           // transform.position = Input.mousePosition;

            InteraciveClone.transform.position = Input.mousePosition;
            InteraciveClone.transform.rotation = new Quaternion(0, 0, 0, 0);
            //Debug.Log(normalizedPoint);
        }
        //canvas.transform.Translate(speed, 0f, 0f);
    }

    public void ResetPosition ()
    {


        InteraciveClone = GameObject.FindGameObjectWithTag("ClonedSticker");
        Destroy(InteraciveClone);

        for (int i = 0; i < canvas.Length; i++)
        {
            canvas[i].GetComponent<ImageAnimator>().ResetPosition();
        }
    }
}
