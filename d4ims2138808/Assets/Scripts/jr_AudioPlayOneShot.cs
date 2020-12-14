using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jr_AudioPlayOneShot : MonoBehaviour
{

    private AudioSource myAudio;
    public AudioClip mySound;
    public float mySoundVolume = 1f;

    // Start is called before the first frame update
    void Start()
    {
        myAudio = transform.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        playOneShotSound();
    }

    public void playOneShotSound()
    {
        myAudio.PlayOneShot(mySound, mySoundVolume);
    }
}
