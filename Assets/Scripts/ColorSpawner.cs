using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSpawner : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject color;
    GameObject spawnColor;
    [SerializeField] GameObject[] prefabs;

    float spawnY;
    float forceAngleX;
    float forceAngleY;
    float forceSpeed;
    float spawnWait;
    int prefabRandom;

    void Start()
    {
        StartCoroutine(SpawnColors());
    }

    IEnumerator SpawnColors() {
        while(true) {
            spawnY = Random.Range(4.0f, -4.0f);
            forceAngleX = Random.Range(4.0f, 1.0f);
            forceAngleY = Random.Range(4.0f, -4.0f);
            forceSpeed = Random.Range(-50f, -100f);
            spawnWait = Random.Range(1.0f, 3.5f);
            prefabRandom = Random.Range(0, 4);

            Vector2 forceAngle = new Vector2(forceAngleX, forceAngleY);
            Vector2 forceHorizontal = new Vector2(4.0f, forceAngleY);

            spawnColor = Instantiate(prefabs[prefabRandom], new Vector3(7.0f, spawnY, 0.0f), Quaternion.identity);
            spawnColor.GetComponent<Rigidbody2D>().AddForce(forceHorizontal * forceSpeed);

            yield return new WaitForSeconds(spawnWait);
        }
    }
}