using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSoundCollision : MonoBehaviour
{

    public AudioSource _as;
    public AudioClip[] audioClipArray;
 
    void OnCollisionEnter2D()  //Plays random sound whenever collision detected
    {
        _as = GetComponent<AudioSource>();
        _as.clip = audioClipArray[Random.Range(0, audioClipArray.Length)];
        _as.PlayOneShot(_as.clip);
        Debug.Log("OnCollisionEnter2D");
    }
}

