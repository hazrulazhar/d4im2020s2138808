using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jr_sceneJumpOnLoad : MonoBehaviour
{
    public string theScene; // the scene to jump to on start;

    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(theScene, LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
