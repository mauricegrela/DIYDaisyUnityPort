using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ParentsCornerActivation : MonoBehaviour {


    public string[] BootColNames;
    public Sprite[] BootCols;
    public Image BootImg;
    public InputField InputRef;
    public GameObject[] Locks;

    private string CorrectAnswer;
    private int CorrectAnswerIndex;

	// Use this for initialization
	void Start () {
        //SetNewImage();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetNewImage()
    {
        Debug.Log("Setting New Image");
        CorrectAnswerIndex = Random.Range(0, BootColNames.Length - 1);
        Debug.Log(BootColNames[CorrectAnswerIndex]);
        CorrectAnswer = BootColNames[CorrectAnswerIndex];
        BootImg.sprite = BootCols[CorrectAnswerIndex];

    }


    public void CheckIfAnswerRight(string Answer)
    {
        Debug.Log(InputRef.text.ToLower() +"///////"+ BootColNames[CorrectAnswerIndex]);
        if(InputRef.text.ToLower() == BootColNames[CorrectAnswerIndex])
        {
            gameObject.SetActive(false);
            for (int i = 0; i <= Locks.Length - 1; i++)
            {
                Locks[i].SetActive(false);
            }
        }
    }

}
