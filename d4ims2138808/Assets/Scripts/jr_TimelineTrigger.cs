using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class jr_TimelineTrigger : MonoBehaviour
{
    // the game object the timeline is attached to
    public GameObject timelineObject;
    private PlayableDirector timeline;

    // Start is called before the first frame update
    void Start()
    {
        timeline = timelineObject.GetComponent<PlayableDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // NB note the doubling up of functions below so I can use this with sprites or UI buttons
    // NB!! note that as part of the doubling up I've created a single function that
    // is called by the other two. Although this is just a single line, imagine if I had a more
    // complex set of functionality, which I only really want to change once!

    void OnMouseDown()
    {
        // call the function; 
        timeline.Play();// 'method' of the PlayableDirector
    }

    public void OnButtonPress()
    {
        // call the function
        playTimeline();
    }

    void playTimeline()
    {
        timeline.Play();
        // now do something else
        // nowdo something else
    }

}
