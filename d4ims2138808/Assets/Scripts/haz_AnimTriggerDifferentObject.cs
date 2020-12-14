using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haz_AnimTriggerDifferentObject : MonoBehaviour {

	public GameObject objectToAnim; // we can rotate a different object
	public Animator anim;// an 'imaginary' object called anim of type Animator
	public AudioSource audio;

	public bool openState = false;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown(){
		Debug.Log("Open Box "+objectToAnim.ToString());
		this.swapper();
		Debug.Log("openState: "+this.openState);
	}

	// a 'custom' function
	void swapper()
	{
		this.openState = !openState;// this 'inverts' the boolean (e.g. when true, set false, when false, set true)
		this.anim.SetBool("open", this.openState);// the thing in quotes is the name of the param in the controller
		audio = GetComponent<AudioSource>();
		audio.Play(0);
	}

}
