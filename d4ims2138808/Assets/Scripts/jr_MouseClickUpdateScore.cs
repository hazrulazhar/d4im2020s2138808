using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jr_MouseClickUpdateScore : MonoBehaviour
{

    private GameObject otherObject;// the object the other script is on

    // Start is called before the first frame update
    void Start()
    {
        otherObject = GameObject.FindWithTag("ScoreKeeper");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        otherObject.GetComponent<jr_otherScriptValue>().updateScore();
    }
}
