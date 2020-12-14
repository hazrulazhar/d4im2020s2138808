using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jr_ShowContextItem : MonoBehaviour
{
    public GameObject[] objectsToHide;

    // integer variable to store number of 'child' items of whatever gameObject
    // this script is attached to
    private int nChildCount;

    // string - szMyString
    // integer - nMyInteger
    // boolean - bMyBool
    // float - fMyFloat

    // Start is called before the first frame update
    void Start()
    {
        // transform = the object this is attached to
        nChildCount = transform.childCount;
        // concatenation means adding some variables together (often as a string)
        //Debug.Log("There are this many children of this object: " + nChildCount)
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showContextItemClick(GameObject goToShow)
    {
        // Debug.Log("click");
        // deactivate off any currently visible item
        hideAllChildObjects();
        goToShow.SetActive(true);
    }

    private void hideAllObjects()
    {
        // could use a 'for' loop but here using 'foreach'
        foreach (GameObject currentobject in objectsToHide)
        {// objectsToHide is the array we're looping around
            // currentObject is the current position in the array
            currentobject.SetActive(false);
        }
    }


    private void hideAllChildObjects()// hide all 'children' of a parent
    {
        // a 'for' loop - will loop from a number to a number,
        // incrementing current number by 1 as we go
        for(int i = 0; i < nChildCount; i++)
        {
            // transform.GetChild(i).gameObject;
            transform.GetChild(i).gameObject.SetActive(false);
        }

    }
}
