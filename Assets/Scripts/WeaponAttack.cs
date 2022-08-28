using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAttack : MonoBehaviour
{   
    public GameObject objectWithScript;
    ColorPicker _colorPicker;
    string colorWeapon;
    Camera mainCamera;

    public GameObject bulletPrefab;
    GameObject bullet;

    public float forceBullet = 10.0f; 
    
    void Start() {
        _colorPicker = objectWithScript.GetComponent<ColorPicker>();
        mainCamera = Camera.main;
    }

    void Update() {
        if (Input.GetMouseButtonDown(0))
        {
            
            Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            Vector3 direction = mousePos - transform.position;

            Vector3 mousePosAlt;
            mousePosAlt = Input.mousePosition;
            if (mousePosAlt.x < mainCamera.pixelWidth / 2.0f)
            {
                var hit = Physics2D.Linecast(transform.position, mousePos);
                bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x, direction.y).normalized * forceBullet;
            }
            
            // Vector2 _force = transform.position - hit.transform.position;
            // Vector2 _normForce = Vector3.Normalize(_force);
            // hit.rigidbody.velocity = _normForce * 5.0f;
        }

        colorWeapon = _colorPicker.colorWeapon;
        //Debug.Log(_colorPicker.colorWeapon);
    }
}
