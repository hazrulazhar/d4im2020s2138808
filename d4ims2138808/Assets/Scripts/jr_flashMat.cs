using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jr_flashMat : MonoBehaviour
{

    private bool bFlash = false;

    private Renderer rend;
    private Color col;
    public Vector4 colVec1;//XYZW = RGBA
    public Vector4 colVec2;

    private int frameCounter = 0;
    public int maxFrameCount;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = colVec1;
    }

    // Update is called once per frame
    void Update()
    {
        if (bFlash)// this will only work when we're over the object
        {
            frameCounter += 1;
            if (frameCounter > maxFrameCount) frameCounter = 0;
            if (frameCounter < maxFrameCount / 2) rend.material.color = colVec2;
            else rend.material.color = colVec1;
        }
    }


    // see https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnMouseOver.html
    // you'll need to add a collider if you don't have one already
    void OnMouseOver()
    {
        bFlash = true;
    }

    void OnMouseExit()
    {
        bFlash = false;
        rend.material.color = colVec1;
        frameCounter = 0;
    }

    void OnMouseDown()
    {
       //doSomething();
    }
}
