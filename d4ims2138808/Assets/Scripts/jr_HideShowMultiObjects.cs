using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jr_HideShowMultiObjects : MonoBehaviour
{
    public GameObject[] toHide;// an array
    public GameObject[] toShow;

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
        showHideObjects();
    }

    public void OnPointerClick()
    {
        showHideObjects();
    }


    private void showHideObjects()
    {
        foreach (GameObject obj in toHide)
        {// loop round objects to hide - obj is the current loop
            obj.SetActive(false);
        }
        foreach (GameObject obj in toShow)
        {// loop round objects to hide      
            obj.SetActive(true);
        }
    }
}
