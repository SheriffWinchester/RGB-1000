using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{

    LineRenderer _LineRenderer;
    Camera mainCamera;
    GameObject _colorSquare;
    //[SerializeField] public LayerMask _layerMask;
    string[] colors = {"WhiteColor", "BlackColor", "RedColor", "GreenColor", "BlueColor"};
    public float laserLength = 10f;
    public float forcePull = 0.3f;

    string name1;
    string name2;
    string temp;

    // public int playerLayer = 8;
    // int layerMask = ~(1 << playerLayer);
    
    void Start()
    {
        _LineRenderer = GetComponent<LineRenderer>();
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);   
            Vector2 direction = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);
            var hit = Physics2D.Linecast(transform.position, mousePos);

            if (hit.collider != null)
            {
                // _LineRenderer.SetPosition(0, transform.position);
                // _LineRenderer.SetPosition(1, hit.transform.position);
                // _LineRenderer.enabled = true;

                Vector2 _force = transform.position - hit.transform.position;
                Vector2 _normForce = Vector3.Normalize(_force);
                hit.rigidbody.velocity = _normForce * 5.0f;
            } 
            // else 
            // {
            //     _LineRenderer.enabled = false;
            // }
        }


        // Vector2 ray = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        // Vector2 direction = new Vector2(ray.x - transform.position.x, ray.y - transform.position.y);
        // Debug.DrawRay(transform.position, direction, Color.red);
    }

    // void ShootRay()
    // {
        
    // }
    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "Colors")
        {
            Destroy(col.gameObject);
        }
    }
}
