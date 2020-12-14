using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jr_getOtherScriptValue : MonoBehaviour
{

    public GameObject otherObject;// the object the other script is on
    private string otherVal = "value";

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
        otherVal = otherObject.GetComponent<jr_otherScriptValue>().myVal;
        Debug.Log(otherVal);
        // call function in the 'other' script
        otherObject.GetComponent<jr_otherScriptValue>().showVal();
        otherObject.GetComponent<jr_otherScriptValue>().updateScore();
    }
}
