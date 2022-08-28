using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{

    void Start() {
        Destroy(gameObject, 4);
    }

    void OnCollisionEnter2D(Collision2D col) {
        if (col.collider.gameObject.name == "AttackBoundary" || col.collider.gameObject.name == "Bullet(Clone)")
        {
            Destroy(gameObject);
        }
    }

}
