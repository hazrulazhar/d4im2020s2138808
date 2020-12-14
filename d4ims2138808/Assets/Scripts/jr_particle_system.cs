using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jr_particle_system : MonoBehaviour {

	private GameObject parentGo;// ref to parent

	public GameObject prefab;// ref to object for instantiation

	public List<GameObject> myObjects = new List<GameObject>(); // fft particles
	// this is essentially an arrayList - see http://wiki.unity3d.com/index.php/Choosing_the_right_collection_type 

	private GameObject currentobject;// current object - reused
	private Vector3 position;// position - reused

	public int numObjects = 1;// the number here will be the 'default'
    public float minSpeed = 0f;
    public float maxSpeed = 0f;
    public float maxHeight = 5f;
    public float minX = 0f;
    public float maxX = 0f;
    public float minY = 0f;
    public float maxY = 0f;

	// Use this for initialization
	void Start () {
		parentGo = gameObject;// set parent
		position = new Vector3(0f,0f,0f);
		MakeObjects(numObjects);
	}

	// Update is called once per frame
	void Update () {
		MoveObjects();
	}

	void MakeObjects(int numToMake){
		for(int i = 0; i < numToMake; i++){
		// randomise position
		position.x = Random.Range(minX,maxX);
		position.y = Random.Range(minY, maxY);
        if (numToMake == 1) position.y = minY;
        position.z = 0f;
		// instantiate Cube & set start position
		currentobject = Instantiate(prefab, position, Quaternion.identity);
		// set the speed
	    currentobject.GetComponent<jr_speedvar>().fSpeed = Random.Range(minSpeed,maxSpeed);
		// attach to parent
		currentobject.transform.parent = parentGo.transform;
		// add to list
		myObjects.Add(currentobject);
		}
	}

	void MoveObjects(){
		// how many objects
		numObjects = myObjects.Count;
		// loop around them (backwards) - reposition them
		for(int i = numObjects - 1; i >= 0; i--){
			// store the current position for the object
			position = myObjects[i].transform.position;
			// update the y position from the SpeedVar script.
			position.y = position.y + myObjects[i].GetComponent<jr_speedvar>().fSpeed;
			// reposition the object
			myObjects[i].transform.position = position;
			// check height and destroy?
			if(myObjects[i].transform.position.y > maxHeight) {
				Destroy(myObjects[i]);
				//fft[i].SetActive(false);
				myObjects.RemoveAt(i);
				// make a new one
				MakeObjects(1);
			}
		}

	}
}
