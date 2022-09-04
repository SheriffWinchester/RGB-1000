using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletColor : MonoBehaviour {

    string[] colors = {"WhiteColor(Clone)", "BlackColor(Clone)", "RedColor(Clone)", 
    "GreenColor(Clone)", "BlueColor(Clone)", "BrownColor", "PurpleColor", "IndigoColor"};

    public GameObject objectWithScript;
    ColorPicker _colorPicker;
    SpriteRenderer _spriteRenderer;
    
    public Color32 brown = new Color(128, 64, 0, 255);
    public Color32 purple = new Color(128, 0, 128, 255);
    public Color32 indigo = new Color(0, 106, 209, 255);

    void Start()
    {
        objectWithScript = GameObject.FindWithTag("Support");
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _colorPicker = objectWithScript.GetComponent<ColorPicker>();
    }

    

    void Update() 
    {
        string colorPicked = _colorPicker.colorWeapon;

        if(colorPicked == colors[2])
        {
            _spriteRenderer.color = Color.red;
        }
        if(colorPicked == colors[3])
        {
            _spriteRenderer.color = Color.green;
        }
        if(colorPicked == colors[4])
        {
            _spriteRenderer.color = Color.blue;
        }
        if(colorPicked == colors[5])
        {
            _spriteRenderer.color = brown;
        }
        if(colorPicked == colors[6])
        {
            _spriteRenderer.color = purple;
        }
        if(colorPicked == colors[7])
        {
            _spriteRenderer.color = indigo;
        }
    }
    
}