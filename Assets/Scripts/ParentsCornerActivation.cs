using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ParentsCornerActivation : MonoBehaviour {


    public string[] BootColNames;
    public Color[] BootCols;
    public Image BootImg;
    public InputField InputRef;

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
        CorrectAnswerIndex = Random.Range(0, BootColNames.Length - 1);
        Debug.Log(BootColNames[CorrectAnswerIndex]);
        CorrectAnswer = BootColNames[CorrectAnswerIndex];
        BootImg.color = BootCols[CorrectAnswerIndex];

    }


    public void CheckIfAnswerRight(string Answer)
    {
        if(InputRef.text.ToLower() == BootColNames[CorrectAnswerIndex])
        {
            gameObject.SetActive(false);
        }
    }

}
