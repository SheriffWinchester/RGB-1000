using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupportMovement : MonoBehaviour
{

    Rigidbody2D rb;
    Vector2 move;
    GameObject _camera;
    Camera MainCamera;

    public float movementSpeed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _camera = GameObject.FindWithTag("MainCamera");
        if(_camera != null)
        {
            MainCamera = _camera.GetComponent<Camera>();
        }
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        // Vector2 position = rb.position;
        // position.x = position.x + movementSpeed * horizontal;
        // position.y = position.y + movementSpeed * vertical;

        Vector3 mousePos;
        mousePos = Input.mousePosition;
        if (mousePos.x > MainCamera.pixelWidth / 2.0f)
        {
            rb.velocity = new Vector2(move.x * movementSpeed, move.y * movementSpeed);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
    void Update()
    {
        move = new Vector2(0.0f, Input.GetAxisRaw("Vertical"));
    }
}
