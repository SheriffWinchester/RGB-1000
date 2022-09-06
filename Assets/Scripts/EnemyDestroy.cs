using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{

    public int health = 3;

    SpriteRenderer _spriteRendererBullet;
    BulletColor _bulletColor;
    public ScoreController scoreController;

    void Start()
    {
        scoreController = GameObject.FindWithTag("GameController").GetComponent<ScoreController>();
        Destroy(gameObject, 4);
        _bulletColor = GetComponent<BulletColor>();
    }

    void Update()
    {
        if(health <= 0)
        {
            scoreController.score += 30;
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col) {
        if (col.collider.gameObject.name == "AttackBoundary")
        {
            scoreController.score -= 10;
            Destroy(gameObject);
        }
        if (col.collider.gameObject.tag == "Bullet")
        {
            Debug.Log("Health: " + health);
            health -= 1;
        }
    }


}
