using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jr_otherScriptValue : MonoBehaviour
{

    public string myVal = "the string value";
    public int theScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showVal()
    {
        Debug.Log("my value is: " + myVal);
    }

    public void updateScore()
    {
        theScore += 1;// theScore = theScore + 1;
        Debug.Log("my score is: " + theScore);
    }
}
