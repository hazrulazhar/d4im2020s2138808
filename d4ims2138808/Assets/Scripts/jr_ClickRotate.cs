using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jr_ClickRotate : MonoBehaviour
{
    public int amountRotation = 0;
    public int targetRotation = 0;

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
        gameObject.transform.eulerAngles = new Vector3(
        gameObject.transform.eulerAngles.x,
        gameObject.transform.eulerAngles.y,
        gameObject.transform.eulerAngles.z + amountRotation);
        if(Mathf.Floor(gameObject.transform.eulerAngles.z) == targetRotation)
        {
            //do something
            Debug.Log("reached target");
            GameManager.instance.updateRotateScore();
        }

    }

}
