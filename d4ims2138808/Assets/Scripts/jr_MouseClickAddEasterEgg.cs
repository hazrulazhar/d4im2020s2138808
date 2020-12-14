using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jr_MouseClickAddEasterEgg : MonoBehaviour
{
    private bool clicked = false;

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
        //if (!clicked) GameManager.instance.addEasterEgg();
        //clicked = true;
        OnClickAddEasterEgg();
    }

    public void  OnClickAddEasterEgg()
    {
        if (GameManager.instance.eggsFound.Contains(gameObject.name))
        {
            // do nothing
        }
        else GameManager.instance.addEasterEgg(gameObject.name);
    }

}
