using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jr_SwapSpriteButton : MonoBehaviour
{

    // modified from https://answers.unity.com/questions/1172061/how-to-change-image-of-button-when-clicked.html
    public Sprite OffSprite;
    public Sprite OnSprite;
    private Image BtnImg; 


    // Start is called before the first frame update
    void Start()
    {
        BtnImg = transform.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        ChangeImage();
    }

    public void ChangeImage()
    {
        if (BtnImg.sprite == OnSprite)
        {
            BtnImg.sprite = OffSprite;
        }
        else
        {
            BtnImg.sprite = OnSprite;
        }
    }

}
