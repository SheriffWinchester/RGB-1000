using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    string[] colors = {"WhiteColor(Clone)", "BlackColor(Clone)", "RedColor(Clone)", "GreenColor(Clone)", "BlueColor(Clone)"};
    public string colorWeapon;
    
    void OnCollisionEnter2D(Collision2D col)
    {
        for (int i = 0; i < colors.Length; i++) {
            if (col.collider.gameObject.name == colors[i])
            {
                colorWeapon = colors[i];
                //Debug.Log(colorWeapon);
            }
        }
    }
}
