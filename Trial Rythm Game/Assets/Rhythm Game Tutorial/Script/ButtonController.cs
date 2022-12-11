using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private SpriteRenderer _theSR;
    public Sprite defaultSprite;
    public Sprite pressedImage;

    public KeyCode keyToPress;

    // Start is called before the first frame update
    void Start()
    {
        _theSR = GetComponent<SpriteRenderer>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress)){
            _theSR.sprite = pressedImage;
        }
        if(Input.GetKeyUp(keyToPress)){
            _theSR.sprite = defaultSprite;
        }
    }
}
