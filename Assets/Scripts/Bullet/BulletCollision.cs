using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour {

    SpriteRenderer _spriteRenderer;
    BulletColor _bulletColor;

    void Start()
    {
        _bulletColor = GetComponent<BulletColor>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        string colorObject = col.gameObject.name;
        if(_spriteRenderer.color == Color.red && colorObject == "RedColor(Clone)")
        {
            Destroy(col.collider.gameObject);
        }
        if(_spriteRenderer.color == Color.green && colorObject == "GreenColor(Clone)")
        {
            Destroy(col.collider.gameObject);
        }
        if(_spriteRenderer.color == Color.blue && colorObject == "BlueColor(Clone)")
        {
            Destroy(col.collider.gameObject);
        }
        if(_spriteRenderer.color == _bulletColor.brown && colorObject == "BrownColor(Clone)")
        {
            Destroy(col.collider.gameObject);
        }
        if(_spriteRenderer.color == _bulletColor.purple && colorObject == "PurpleColor(Clone)")
        {
            Destroy(col.collider.gameObject);
        }
        if(_spriteRenderer.color == _bulletColor.indigo && colorObject == "IndigoColor(Clone)")
        {
            Destroy(col.collider.gameObject);
        }
    }
}