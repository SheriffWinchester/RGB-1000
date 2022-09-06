using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour {

    SpriteRenderer _spriteRenderer;
    public BulletColor _bulletColor;
    public ScoreController scoreController;

    void Start()
    {
        scoreController = GameObject.FindWithTag("GameController").GetComponent<ScoreController>();
        _bulletColor = GetComponent<BulletColor>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        string colorObject = col.gameObject.name;

        if(_spriteRenderer.color == Color.red && colorObject == "RedEnemy(Clone)")
        {
            Debug.Log("Got it");
            scoreController.score += 100;
            Destroy(col.collider.gameObject);
        }
        if(_spriteRenderer.color == Color.green && colorObject == "GreenEnemy(Clone)")
        {
            scoreController.score += 100;
            Destroy(col.collider.gameObject);
        }
        if(_spriteRenderer.color == Color.blue && colorObject == "BlueEnemy(Clone)")
        {
            scoreController.score += 100;
            Destroy(col.collider.gameObject);
        }
        if(_spriteRenderer.color == _bulletColor.brown && colorObject == "BrownEnemy(Clone)")
        {
            scoreController.score += 100;
            Destroy(col.collider.gameObject);
        }
        if(_spriteRenderer.color == _bulletColor.purple && colorObject == "PurpleEnemy(Clone)")
        {
            scoreController.score += 100;
            Destroy(col.collider.gameObject);
        }
        if(_spriteRenderer.color == _bulletColor.indigo && colorObject == "IndigoEnemy(Clone)")
        {
            scoreController.score += 100;
            Destroy(col.collider.gameObject);
        }
        Debug.Log(scoreController.score);
    }
}