using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeTest : MonoBehaviour {

    public AudioClip G2;
    public AudioClip G2S;
    public AudioClip A2;
    public AudioClip A2S;
    public AudioClip B2;
    public AudioClip C3;
    public AudioClip C3S;
    public AudioClip D3;
    public AudioClip D3S;
    public AudioClip E3;
    public AudioClip F3;
    public AudioClip F3S;
    public AudioClip G3;
    public AudioClip G3S;
    public AudioClip A3;
    public AudioClip A3S;
    public AudioClip B3;
    public AudioClip C4;
    public AudioClip C4S;
    public AudioClip D4;
    public AudioClip D4S;
    public AudioClip E4;
    public AudioClip F4;


    private AudioSource audioSource; //オーディオソース

    // Use this for initialization
    void Start () {
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void KeyTauch()
    {
        Debug.Log("最初");
        if (tag == "Key_G2")
        {
            audioSource.PlayOneShot(G2);
            Debug.Log("次G2");
        }
        if (tag == "Key_G2S")
        {
            audioSource.PlayOneShot(G2S);
            Debug.Log("次G2#");
        }
        if (tag == "Key_A2")
        {
            audioSource.PlayOneShot(A2);
            Debug.Log("次A2");
        }
        if (tag == "Key_A2S")
        {
            audioSource.PlayOneShot(A2S);
        }
        if (tag == "Key_B2")
        {
            audioSource.PlayOneShot(B2);
            Debug.Log("次B2");
        }
        if (tag == "Key_C3")
        {
            audioSource.PlayOneShot(C3);
        }
        if (tag == "Key_C3S")
        {
            audioSource.PlayOneShot(C3S);
        }
        if (tag == "Key_D3")
        {
            audioSource.PlayOneShot(D3);
        }


    }
}
