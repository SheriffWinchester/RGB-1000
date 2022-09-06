using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletVelocity : MonoBehaviour
{

    Rigidbody2D _rigidBody;
    Vector2 _velocity;

    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _velocity = _rigidBody.velocity;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Bullet")
        {
            _rigidBody.velocity = _velocity;
        }
    }
}