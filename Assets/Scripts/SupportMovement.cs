using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupportMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 move;
    GameObject _camera;
    Camera MainCamera;

    MouseCheck _mouseCheck;

    public float movementSpeed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _mouseCheck = GameObject.FindWithTag("GameController").GetComponent<MouseCheck>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 mousePos;
        mousePos = Input.mousePosition;
        if (_mouseCheck.SupportCharacterMove == true)
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
