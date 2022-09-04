using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCheck : MonoBehaviour
{
    Vector2 move;
    GameObject _camera;
    Camera MainCamera;
    public bool AttackCharacterMove;
    public bool SupportCharacterMove;


    void Start()
    {
        _camera = GameObject.FindWithTag("MainCamera");
        if(_camera != null)
        {
            MainCamera = _camera.GetComponent<Camera>();
        }
    }

    void Update()
    {
        Vector3 mousePos;
        mousePos = Input.mousePosition;
        if (mousePos.x < MainCamera.pixelWidth / 2.0f)
        {
            AttackCharacterMove = true;
            SupportCharacterMove = false;
        }
        else
        {
            AttackCharacterMove = false;
            SupportCharacterMove = true;
        }
    }
}
