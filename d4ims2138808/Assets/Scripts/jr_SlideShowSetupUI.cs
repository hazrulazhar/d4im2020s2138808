using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class jr_SlideShowSetupUI : MonoBehaviour {

    // this script needs to be attached to an object with a sprite renderer

    public string folderName;// the folder in 'resources' where the images live
    private Object[] folderContents;// an array for loading content
    private List<Sprite> slideImages = new List<Sprite>();// an array list

    public int currentImage = 0;

	// Use this for initialization
	void Start () {
        folderContents = Resources.LoadAll(folderName, typeof(Sprite));
        foreach (Sprite s in folderContents)
        {
            //Debug.Log(t.name);
            slideImages.Add(s);
            //Debug.Log("Added");
        }
        if (slideImages.Count > 0){// make sure there's something in the array.
            // set the sprite image on the component to be the 1st thing in the array.
            transform.GetComponent<Image>().sprite = slideImages[currentImage];
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void slideImagePlus(){
		if(slideImages.Count > 0){// defensive - must be something in array
		// add 1 to current image
		currentImage += 1;
		// check that we haven't got a number bigger than the number of slides
        // if we have show the first thing in the array
		// BTW arrays start (generally) at zero.
		if(currentImage == slideImages.Count) currentImage = 0;
        // now set the image
        // set the sprite image on the component to be the thing in the array.
        transform.GetComponent<Image>().sprite = slideImages[currentImage];
		}
	}

	public void slideImageMinus(){
		if(slideImages.Count > 0){//defensive - must be something in array
		// subtract 1 from current image
		currentImage -= 1;
		// check that we haven't got a number smaller than zero
        // if we have show the last item in the array
		// BTW arrays start (generally) at zero.
		if(currentImage <= 0) currentImage = slideImages.Count - 1;
        // now set the image
        // set the sprite image on the component to be the thing in the array.
        transform.GetComponent<Image>().sprite = slideImages[currentImage];
		}
	}

    public void onButtonClick(bool direction)
    {   // if the box is ticked it will play forwards
        if (direction) slideImagePlus();
        else slideImageMinus();
        gameObject.GetComponent<PlayableDirector>().Play();
    }

}
