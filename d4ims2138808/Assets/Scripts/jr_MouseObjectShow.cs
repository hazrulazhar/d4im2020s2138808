using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jr_MouseObjectShow : MonoBehaviour
{

    public GameObject mouseObjectToShow;

    private bool mouseClicked = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // see https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnMouseOver.html
    // you'll need to add a collider if you don't have one already
    void OnMouseOver()
    {
        mouseObjectToShow.SetActive(true);
        //if(!mouseClicked) mouseObjectToShow.SetActive(true);
    }

    void OnMouseExit()
    {
        mouseObjectToShow.SetActive(false);
    }

    private void OnMouseDown()
    {
        //mouseClicked = true;
        //mouseObjectToShow.SetActive(false);
    }
}
