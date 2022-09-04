using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CircleColors1UI : MonoBehaviour {

    string[] colors = {"WhiteColor(Clone)", "BlackColor(Clone)", "RedColor(Clone)", 
    "GreenColor(Clone)", "BlueColor(Clone)", "BrownColor", "PurpleColor", "IndigoColor"};

    public GameObject objectWithScript;
    ColorPicker _colorPicker;
    RawImage _rawImage;
    
    void Start()
    {
        objectWithScript = GameObject.FindWithTag("Support");
        _rawImage = GetComponent<RawImage>();
        _colorPicker = objectWithScript.GetComponent<ColorPicker>();
    }

    void Update() 
    {
        string colorPicked = _colorPicker.slot1;

        if(colorPicked == colors[0])
        {
            _rawImage.color = Color.white;
        }
        if(colorPicked == colors[1])
        {
            _rawImage.color = Color.black;
        }
        if(colorPicked == colors[2])
        {
            _rawImage.color = Color.red;
        }
        if(colorPicked == colors[3])
        {
            _rawImage.color = Color.green;
        }
        if(colorPicked == colors[4])
        {
            _rawImage.color = Color.blue;
        }
    }
    
}