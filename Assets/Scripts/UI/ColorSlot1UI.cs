using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColorSlot1UI : MonoBehaviour {

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
        string colorPicked = _colorPicker.slot1;

        if(colorPicked == colors[0])
        {
            slotsText.text = "1: White";
        }
        if(colorPicked == colors[1])
        {
            slotsText.text = "1: Black";
        }
        if(colorPicked == colors[2])
        {
            slotsText.text = "1: Red";
        }
        if(colorPicked == colors[3])
        {
            slotsText.text = "1: Blue";
        }
        if(colorPicked == colors[4])
        {
            slotsText.text = "1: Green";
        }
        

        
    }
}