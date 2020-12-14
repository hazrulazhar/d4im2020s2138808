using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// this code from http://unitypatterns.com/singletons/

public class GameManager : MonoBehaviour 
{
	private static GameManager _instance;
	
	public static GameManager instance
	{
		get
		{
			if(_instance == null)
			{
				_instance = Object.FindObjectOfType<GameManager>();
				
				//Tell unity not to destroy this object when loading a new scene!
				DontDestroyOnLoad(_instance.gameObject);
			}
			
			return _instance;
		}
	}
	
	void Awake() 
	{
		if(_instance == null)
		{
			//If I am the first instance, make me the Singleton
			_instance = this;
			DontDestroyOnLoad(this);
		}
		else
		{
			//If a Singleton already exists and you find
			//another reference in scene, destroy it!
			if(this != _instance)
				Destroy(this.gameObject);
		}
	}

	// some tests

	public string myGlobalVar = "thisValue";

    // all the real functionality here
    public int numEasterEggs = 0;

    public List<string> eggsFound = new List<string>();// an array list

    public void addEasterEgg(string go)
    {
        if(numEasterEggs < 4) numEasterEggs += 1;
        eggsFound.Add(go);
        Debug.Log(go);
    }

    public void resetEggs()
    {
        Debug.Log("resetting");
        eggsFound = new List<string>();// this removes any existing values
        numEasterEggs = 0;
    }

    private int RotScore = 0;

    public void updateRotateScore()
    {
        RotScore += 1;
        if (RotScore == 4)
        {
            // do something
            Debug.Log("trigger animation");
        }
    }
}