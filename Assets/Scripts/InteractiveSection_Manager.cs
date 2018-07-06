using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

using UnityEngine;

public class InteractiveSection_Manager : MonoBehaviour
{

    public RectTransform[] canvas;
    RectTransform button;
    Vector3 startingPosition;
    public float speed;
    public bool isMoving = false;
    public int inverter = 1;
    public GameObject InteraciveClone;
    public Transform PositionLeft;
    public Transform PositionRight;


    public GameObject PhoneBorderRef;


    public static int ORIENTATION_UNDEFINED = 0x00000000;
    public static int ORIENTATION_PORTRAIT = 0x00000001;
    public static int ORIENTATION_LANDSCAPE = 0x00000002;

    public static int ROTATION_0 = 0x00000000;
    public static int ROTATION_180 = 0x00000002;
    public static int ROTATION_270 = 0x00000003;
    public static int ROTATION_90 = 0x00000001;

    public static int PORTRAIT = 0;
    public static int PORTRAIT_UPSIDEDOWN = 1;
    public static int LANDSCAPE = 2;
    public static int LANDSCAPE_LEFT = 3;


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
        startingPosition = transform.position;
        //speed = -10f;
    }

    public void ActivateBoarder()
    {
        #if UNITY_ANDROID    
        float screenHeightInInch =  Screen.height / Screen.dpi;
            if (screenHeightInInch < 3.1)
            {
            PhoneBorderRef.SetActive(true);
            }
                else
                {
                    // it's tablet
                }
        #else
        bool deviceIsIpad = UnityEngine.iOS.Device.generation.ToString().Contains("iPad");
        if (deviceIsIpad == false)
        {
            PhoneBorderRef.SetActive(true);
        }
        #endif
    }

    public void BoarderLeft()
    {

        Debug.Log("-1800");
        for (int i = 0; i < canvas.Length; i++)
        {
            canvas[i].transform.position = PositionLeft.position;//new Vector2(canvas[i].transform.position.x + 5240, canvas[i].transform.position.y);
        }
    }

    public void BoarderRight()
    {

        Debug.Log("2830");
        for (int i = 0; i < canvas.Length; i++)
        {
            canvas[i].transform.position = PositionRight.position;//new Vector2(canvas[i].transform.position.x  -2124, canvas[i].transform.position.y);
        }
    }

    void Update()
    {
        if(isMoving == true)
        {
            InteraciveClone.transform.position = Input.mousePosition;
            InteraciveClone.transform.rotation = Quaternion.Euler(0, 0, -45 * inverter);
            if (canvas[0].transform.position.x >= 2830)
            {

            }
            if (canvas[0].transform.position.x <= -1800)
            {
                    

            }

            for (int i = 0; i < canvas.Length; i++)
            {
                canvas[i].transform.Translate(speed * inverter, 0f, 0f);
            }
        }
        else if(InteraciveClone != null)
            {
            InteraciveClone.transform.position = Input.mousePosition;
            InteraciveClone.transform.rotation = new Quaternion(0, 0, 0, 0);
            }
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
