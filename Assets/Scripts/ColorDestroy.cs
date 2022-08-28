using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorDestroy : MonoBehaviour
{

    void Start() {
        Destroy(gameObject, 4);
    }

    void OnCollisionEnter2D(Collision2D col) {
        if (col.collider.gameObject.name == "Wall")
        {
            Destroy(gameObject);
        }
    }

}
