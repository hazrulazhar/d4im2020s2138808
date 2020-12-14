using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class jr_ToggleAudio : MonoBehaviour

{
    public GameObject myGO; // the object the Audio Source is attached to
    private AudioSource myAudio;

    // Start is called before the first frame update
    void Start()
    {
        myAudio = myGO.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnMouseDown()
    {
		toggleAudio();
    }
    
    public void toggleAudio(){
        if (myAudio.isPlaying)// is true
        {
            myAudio.Stop();
        }
        else { 
            myAudio.Play();
        }
    }

    }