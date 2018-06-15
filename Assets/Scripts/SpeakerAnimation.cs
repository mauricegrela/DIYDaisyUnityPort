using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SpeakerAnimation : MonoBehaviour {

    public Sprite[] sprites;

    void Start()
    {
       

        StartCoroutine("nukeMethod");
    
    }

    public IEnumerator nukeMethod()
    {
            for (int i = 0; i < sprites.Length; i++)
            {
            gameObject.GetComponent<Image>().sprite = sprites[i];
            yield return new WaitForSeconds(0.5f);
            }     
        StartCoroutine("nukeMethod");
    }
}
