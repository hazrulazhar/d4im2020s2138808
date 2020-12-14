using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jr_RotateDifferentObject : MonoBehaviour {

	public GameObject objectToRotate; // we can rotate a different object
    public float rotationSpeed = 0.5f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseOver(){// see https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnMouseOver.html
		objectToRotate.transform.Rotate(new Vector3(0, rotationSpeed, 0) * 1);
	}

}
