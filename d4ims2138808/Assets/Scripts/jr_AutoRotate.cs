using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jr_AutoRotate : MonoBehaviour
{
    //variable - floating point number - 1.0
    public float rotationSpeed = 30f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // transform means the transform (i.e. position, scale, rotation) of the object this script is attached to
        transform.Rotate(new Vector3(0, rotationSpeed, 0) * Time.deltaTime);
    }
}
