using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOn : MonoBehaviour
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

        if (Input.GetKeyDown(KeyCode.A))
        {
            audioSource.PlayOneShot(G2);
            Debug.Log("A");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            audioSource.PlayOneShot(A2);
            Debug.Log("S");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            audioSource.PlayOneShot(B2);
            Debug.Log("D");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            audioSource.PlayOneShot(C3);
            Debug.Log("F");
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            audioSource.PlayOneShot(D3);
            Debug.Log("G");
        }

        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.GetTouch(0);

            var pos = Input.touches[i].position;

            if (touch.phase == TouchPhase.Began)
            {
                //
                if (tag == "G2")
                {
                    //SetAngle(this.flickAngle);
                }
                if (tag == "A2")
                {
                    //SetAngle(this.flickAngle);
                }
                if (tag == "B2")
                {
                    //SetAngle(this.flickAngle);
                }
                if (tag == "C3")
                {
                    //SetAngle(this.flickAngle);
                }
                if (tag == "D3")
                {
                    //SetAngle(this.flickAngle);
                }

            }
        }
    }
}

