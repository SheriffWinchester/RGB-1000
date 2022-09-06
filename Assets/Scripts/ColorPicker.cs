using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    string[] colors = {"WhiteColor(Clone)", "BlackColor(Clone)", "RedColor(Clone)", 
    "GreenColor(Clone)", "BlueColor(Clone)", "BrownColor", "PurpleColor", "IndigoColor"};
    public string colorWeapon;
    public string slot1;
    public string slot2;
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name != "SouthBoundary" && col.gameObject.name != "NorthBoundary")
        {
            if (slot1 == null)
            {
                slot1 = col.gameObject.name;
            }
            else if (slot1 != null)
            {
                slot2 = slot1;
                slot1 = col.gameObject.name;
            }
            
            //Debug.Log("Slot 1: " + slot1);
            //Debug.Log("Slot 2: " + slot2);
        }
        

        //string colorPicked = col.collider.gameObject.name;

        if (slot1 == colors[2] && slot2 == colors[2]) //Red
        {
            colorWeapon = colors[2];
            Debug.Log("Gotcha: " + colorWeapon);
        }
        if (slot1 == colors[3] && slot2 == colors[3]) //Green
        {
            colorWeapon = colors[3];
            Debug.Log("Gotcha: " + colorWeapon);
        }
        if (slot1 == colors[4] && slot2 == colors[4]) //Blue
        {
            colorWeapon = colors[4];
            Debug.Log("Gotcha: " + colorWeapon);
        }
        if (slot1 == colors[2] && slot2 == colors[3] || 
            slot1 == colors[3] && slot2 == colors[2]) //Brown (Red + Green)
        {
            colorWeapon = colors[5];
            Debug.Log("Gotcha: " + colorWeapon);
        }
        if (slot1 == colors[2] && slot2 == colors[4] || 
            slot1 == colors[4] && slot2 == colors[2]) //Purple (Red + Blue)
        {
            colorWeapon = colors[6];
            Debug.Log("Gotcha: " + colorWeapon);
        }
        if (slot1 == colors[3] && slot2 == colors[4] || 
            slot1 == colors[4] && slot2 == colors[3]) //Indigo (Green + Blue)
        {
            colorWeapon = colors[7];
            Debug.Log("Gotcha: " + colorWeapon);
        }
    }
}
