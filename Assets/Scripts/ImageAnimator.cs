﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ImageAnimator : MonoBehaviour {

    public Sprite[] sprites;
    public float animationSpeed;
    public bool isAnimated;
    private bool isAnimating = false;
    private Vector3 OGPose;
    public AudioSource SFXSource;
    public AudioClip PlaceSound;

    void Start()
    {
        OGPose = transform.position;
        /*if (isAnimated == true)
        { 
        StartCoroutine("nukeMethod");
        }*/
    }

    public IEnumerator nukeMethod()
    {
            for (int i = 0; i < sprites.Length; i++)
            {
                if (isAnimating == true)
                {
                gameObject.GetComponent<Image>().sprite = sprites[i];
                }

                if (isAnimating == true)
                {
                yield return new WaitForSeconds(animationSpeed);
                }
                    else
                    {
                    yield return null;
                    }
            }
        //isAnimating = false;
        if (isAnimating == true)
        {
        StartCoroutine("nukeMethod");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (isAnimating == false)
        {
            SFXSource.clip = PlaceSound;
            SFXSource.Play();
            SFXSource.loop = true;
            isAnimating = true;
            StartCoroutine("nukeMethod"); //Debug.Log("Triggered");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        //SFXSource.Play();
        SFXSource.loop = false;

        isAnimating = false;
        gameObject.GetComponent<Image>().sprite = sprites[0];
    }

    public void ResetPosition()
    {
        transform.position = OGPose;
    }
}
