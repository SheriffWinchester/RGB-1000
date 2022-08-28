using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.collider.gameObject.name == "Wall" || col.collider.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            Debug.Log("WAAAAAAALLL");
        }
    }
}