using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jr_particle_basic : MonoBehaviour {

	private GameObject parentGo;// ref to parent

	public GameObject prefab;// ref to object for instantiation

	public List<GameObject> myObjects = new List<GameObject>(); // 
	// this is essentially an arrayList - see http://wiki.unity3d.com/index.php/Choosing_the_right_collection_type 

	private GameObject currentobject;// current object - reused
	private Vector3 position;// position - reused

	// Use this for initialization
	void Start () {
		parentGo = gameObject;// set parent
		position = new Vector3(0f,0f,0f);
		MakeObjects();
	}

	// Update is called once per frame
	void Update () {
		MoveObjects();
	}

	void MakeObjects(){
            // instantiate Cube & set start position
            currentobject = Instantiate(prefab, position, Quaternion.identity);
            // attach to parent
            currentobject.transform.parent = parentGo.transform;
            // add to list
            myObjects.Add(currentobject);
	}

	void MoveObjects(){
		// how many objects
		int numObjects = myObjects.Count;
		// loop around them (backwards) - reposition them
		for(int i = numObjects - 1; i >= 0; i--){// i = our 'index' to the array
			// store the current position for the object
			position = myObjects[i].transform.position;
			// update the y position
			position.y = position.y + 0.01f;
			// reposition the object
			myObjects[i].transform.position = position;
		}

	}
}
