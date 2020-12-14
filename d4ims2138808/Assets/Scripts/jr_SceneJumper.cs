using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jr_SceneJumper : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

    // this is used with UI Buttons
	public void GoToScene(string theScene){
	SceneManager.LoadScene(theScene, LoadSceneMode.Single);
	Debug.Log(theScene);
	}

}
