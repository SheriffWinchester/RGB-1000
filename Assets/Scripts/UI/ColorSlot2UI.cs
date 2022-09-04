using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColorSlot2UI : MonoBehaviour {

    string[] colors = {"WhiteColor(Clone)", "BlackColor(Clone)", "RedColor(Clone)", 
                       "GreenColor(Clone)", "BlueColor(Clone)", "BrownColor(Clone)", 
                       "PurpleColor(Clone)", "IndigoColor(Clone)"};

    public TextMeshProUGUI slotsText;

    public GameObject objectWithScript;
    ColorPicker _colorPicker;
    
    void Start() 
    {
        objectWithScript = GameObject.FindWithTag("Support");
        _colorPicker = objectWithScript.GetComponent<ColorPicker>();
        slotsText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        string colorPicked = _colorPicker.slot2;

        if(colorPicked == colors[0])
        {
            slotsText.text = "2: White";
        }
        if(colorPicked == colors[1])
        {
            slotsText.text = "2: Black";
        }
        if(colorPicked == colors[2])
        {
            slotsText.text = "2: Red";
        }
        if(colorPicked == colors[3])
        {
            slotsText.text = "2: Blue";
        }
        if(colorPicked == colors[4])
        {
            slotsText.text = "2: Green";
        }
        

        
    }
}