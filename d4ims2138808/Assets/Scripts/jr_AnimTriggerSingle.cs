using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jr_AnimTriggerSingle : MonoBehaviour
{

    Animator anim;// an 'imaginary' object called anim of type Animator
    int numClicks = 0;

    public GameObject[] gameObjects; // an array of game objects

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

    }

    
    // you'll need to add a collider if you don't have one already
    void OnMouseDown()
    {
        // first check to see 
        if(numClicks < gameObjects.Length) { 
        anim = gameObjects[numClicks].GetComponent<Animator>();
        anim.SetBool("open", true);
        // now add one to the click
        numClicks += 1;
        }
    }


}
