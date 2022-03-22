using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    private float spawnLimitZ = 0.0f;
    private SpawnManager manager;
    void Start()
    {
        manager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }
    void Update()
    {
        if (manager.gameOver == false)
        {
            transform.Translate(Vector3.back * Time.deltaTime * manager.speed);
        }
        if (gameObject.transform.position.z < spawnLimitZ)
        {
            Destroy(gameObject);
            manager.gameOver = true;
        }
    }
}
