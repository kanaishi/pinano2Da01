using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundON : MonoBehaviour
{

    public AudioClip G2;
    public AudioClip A2;
    public AudioClip B2;
    public AudioClip C3;
    public AudioClip D3;
    public AudioClip E3;

    private AudioSource audioSource; //オーディオソース


    // Use this for initialization
    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

   

     
}

