using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPower : MonoBehaviour
{
    public GameObject powerupPrefab;
    public GameObject powerdownPrefab;
    private SpawnManager spawnManagerPower;
    void Start()
    {
        spawnManagerPower = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }
    void Update()
    {
        
    }
    public void SpawnPowerup()
    {
        int powerup = Random.Range(1, 3);
        switch (powerup)
        {
            case 1:
                if (spawnManagerPower.speed > 4.0f)
                {
                    spawnManagerPower.speed -= 0.5f;
                }
                break;
            case 2:
                if (spawnManagerPower.forwardSpeed < 12)
                {
                    spawnManagerPower.forwardSpeed += 0.5f;
                }
                break;
            default:
                break;
        }
        spawnManagerPower.enemySpeed.text = "Enemy Speed: " + spawnManagerPower.speed;
        spawnManagerPower.Speed.text = "Speed: " + spawnManagerPower.forwardSpeed;
    }
    public void Spawndown()
    {
        int powerdown = Random.Range(1, 3);
        switch (powerdown)
        {
            case 1:
                if (spawnManagerPower.forwardSpeed > 4.0f)
                {
                    spawnManagerPower.forwardSpeed -= 0.5f;
                }
                break;
            case 2:
                if (spawnManagerPower.speed < 12)
                {
                    spawnManagerPower.speed += 0.5f;
                }
                break;
            default:
                break;
        }
        spawnManagerPower.enemySpeed.text = "Enemy Speed: " + spawnManagerPower.speed;
        spawnManagerPower.Speed.text = "Speed: " + spawnManagerPower.forwardSpeed;
    }
}
