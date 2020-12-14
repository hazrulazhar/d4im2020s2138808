using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jr_AnimTrigger : MonoBehaviour
{

    Animator anim;// an 'imaginary' object called anim of type Animator

    public bool openState = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();// sets anim to be the Animator attached to the object
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
			// call the swapper function
            swapper();
        }
    }


    // you'll need to add a collider if you don't have one already
    void OnMouseDown()
    {
        // call the swapper function
        swapper();
        // now do something else
    }

    // a 'custom' function
    void swapper()
    {
        openState = !openState;// this 'inverts' the boolean (e.g. when true, set false, when false, set true)
        anim.SetBool("open", openState);// the thing in quotes is the name of the param in the controller

    }


}
