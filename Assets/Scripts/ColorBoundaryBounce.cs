using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBoundaryBounce : MonoBehaviour
{
    private Rigidbody2D rb;

    Vector2 lastVelocity;

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        lastVelocity = rb.velocity;
    }

    void OnCollisionEnter2D(Collision2D col) {
        var speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, col.contacts[0].normal);

        rb.velocity = direction * Mathf.Max(speed, 0f);
    }
}
