using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jr_showEasterEggs : MonoBehaviour
{
    private int nChildCount;
    // Start is called before the first frame update
    void Start()
    {
        nChildCount = transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        // adding the for loop here is a bit
        // 'heavy-handed', but it works!
        for (int i = 0; i < nChildCount; i++)
        {   //deactivate them all off first
            transform.GetChild(i).gameObject.SetActive(false);
        }
        for (int i = 0; i < GameManager.instance.numEasterEggs; i++)
        {
            // now activate as many as necessary
            transform.GetChild(i).gameObject.SetActive(true);
        }
    }
}
