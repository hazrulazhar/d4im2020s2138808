using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haz_QuitApp : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void exitApp() {
		Application.Quit(); // quit the app
    Debug.Log("App exiting");
	}

}
