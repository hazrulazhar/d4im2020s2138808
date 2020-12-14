using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class jr_TimelineTriggerToggle : MonoBehaviour
{
    // NB this is an 'array' of game objects, so you need to set the
    // size in the inspector before it can be used!
    public GameObject[] timelineObject;
    private bool toggle = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        toggleTimelines();
    }

    public void OnButtonPress()
    {
        // call the function;
        toggleTimelines();
    }

    void toggleTimelines()
    {
        // call the function;
        // if condition is met, do something, else do something else
        // if(toggle == false) is the same as if(!toggle) is the same as (false)

        if (!toggle) timelineObject[0].GetComponent<PlayableDirector>().Play();
        else timelineObject[1].GetComponent<PlayableDirector>().Play();
        // invert the toggle value
        //if (toggle == true) toggle = false;
        //else toggle = true;
        toggle = !toggle;

    }

}
