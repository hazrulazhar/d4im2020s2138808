using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class jr_MouseFollower : MonoBehaviour
{//sourced from https://www.youtube.com/watch?v=0yHBDZHLRbQ, but modified

    private float mZCoord;

    private Vector3 GetMouseAsWorldPoint()

    {

        // Pixel coordinates of mouse (x,y)
        Vector3 mousePoint = Input.mousePosition;

        // grab z coordinate of object
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        // now set that as mousepoint
        mousePoint.z = mZCoord;

        // Convert it to world points
        return Camera.main.ScreenToWorldPoint(mousePoint);

    }


    void Update()
    {
        transform.position = GetMouseAsWorldPoint();
    }


}