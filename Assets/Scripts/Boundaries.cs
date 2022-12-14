using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour {
    GameObject _camera;
    Camera MainCamera;
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;

    // Use this for initialization
    void Start () {
        _camera = GameObject.FindWithTag("MainCamera");
        if(_camera != null)
        {
            MainCamera = _camera.GetComponent<Camera>();
        }
        screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(MainCamera.pixelWidth, MainCamera.pixelHeight, MainCamera.transform.position.z));
        objectWidth = transform.GetComponent<BoxCollider2D>().bounds.extents.x; //extents = size of width / 2
        objectHeight = transform.GetComponent<BoxCollider2D>().bounds.extents.y; //extents = size of height / 2
    }

    // Update is called once per frame
    void LateUpdate(){
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + objectWidth, screenBounds.x - objectWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y * -1 + objectHeight, screenBounds.y - objectHeight);

        transform.position = viewPos;
    }
}