/***
Author: Hazrul Azhar Bin Jamari, S2138808
Original Author: Dr Julian Robinson, University of Edinburgh

I rewrote the script to meet the following conditions:
- Auto Rotate on Start
- Stop rotating when mouse over
- Open the box when mouse down
- Rotate to the direction of the mouse drag

*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jr_RotateObject : MonoBehaviour {

    public bool rotateState = true;
    public int rotateDirection = 30;
    public float entryX;
    public float exitX;

    // Use this for initialization
    void Start () {

	  }

  	// Update is called once per frame
  	void Update () {
      // transform means the transform (i.e. position, scale, rotation) of the object this script is attached to
      // Hazrul: This now rotates the object rotate direction automatically to the direction of the last mouse drag direction.
      if (this.rotateState==true) {
          transform.Rotate(new Vector3(0, rotateDirection, 0) * Time.deltaTime);
      }
  	}

    // NB These require a 'Collider' to be attached to the object

	void OnMouseOver(){// see https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnMouseOver.html
		  this.rotateState=false;
      transform.Rotate(new Vector3(0, 0, 0)); // Stop the rotation on mouseover.
	}

  void OnMouseExit(){
    this.rotateState=true;
  }


	void OnMouseDrag(){// see https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnMouseDrag.html
    	// Allow user to tap and drag the object to rotate.

      // This just tells me the coordinates of the mouse to help me understand how to write the logic in the subsequent lines.
      Vector3 direction = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
      Debug.Log("MouseDrag Position: " + direction.ToString("F3"));
      exitX = Input.mousePosition.x;
      string Dir = "";

      // Determine which direction to rotate towards
      // So I only care about the X-axis.
      // I take the entryX which is the position the mouse went down, and subtract with exitX which is the mouse position when dragged
      // If entry is less than exit, then it goes right.
      if (entryX < exitX) {
        rotateDirection = -2; // right
        Dir = "right";
      } else {
        rotateDirection = 2; // left
        Dir = "left";
      }

      Vector3 directionTarget = new Vector3(0,rotateDirection,0);
      Debug.Log("Direction to Rotate: " + Dir + ", " + directionTarget.ToString("F3"));
      transform.Rotate(directionTarget * 1);
  }

  void OnMouseUp() {
    // This just tells me the coordinates of the mouse to help me understand how to write the logic in the subsequent lines.
    Vector3 direction = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
    Debug.Log("MouseUp Position: " + direction.ToString("F3"));
    
  }


  void OnMouseDown(){ // this only works once per /click
		// this object was clicked - do something
    // This just tells me the coordinates of the mouse to help me understand how to write the logic in the subsequent lines.
    Vector3 direction = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
    Debug.Log("MouseDown Position: " + direction.ToString("F3"));
    entryX = Input.mousePosition.x;

	}
}
