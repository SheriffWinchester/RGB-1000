using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter(Collision collision) 
    {
        Debug.Log(collision.gameObject.name);
        if(collision.gameObject.name == "Wall")
        {
            Debug.Log("Hit");
            rb.velocity = Vector2.zero;
        }
    }
}
