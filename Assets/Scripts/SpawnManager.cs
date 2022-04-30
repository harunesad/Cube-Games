using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefab;
    private int posOptions;
    private float posZ = 12.0f;
    public float speed = 5;
    public bool gameOver = false;
    public float repeat = 1.0f;
    public float rate = 1.0f;
    public float point = 0;
    public Text skor;
    private float time = 0;
    public float spawnTime = 0;
    public int count, powerCount, powerDownCount;
    public Difficulty diffi;
    public float forwardSpeed = 6;
    public SpawnPower spawnPower;
    public Text enemySpeed, Speed;
    void Start()
    {
        enemySpeed.text = "Enemy Speed: " + speed;
        Speed.text = "Speed: " + forwardSpeed;
        gameOver = false;
        skor.text = "Point: " + point;
        InvokeRepeating("SpawnPos", rate, repeat);
    }
    public Vector3 SpawnCoins()
    {
        float PositionX = Random.Range(-3.75f, 3.75f);
        float PositionZ = Random.Range(0, 10);
        Vector3 random = new Vector3(PositionX, 0.5f, PositionZ);
        return random;
    }
    public Vector3 SpawnPowerup()
    {
        float PowerPositionX = Random.Range(-3.75f, 3.75f);
        float PowerPositionZ = Random.Range(0, 10);
        Vector3 randomPower = new Vector3(PowerPositionX, 0.5f, PowerPositionZ);
        return randomPower;
    }
    public Vector3 SpawnPowerdown()
    {
        float PowerdownPositionX = Random.Range(-3.75f, 3.75f);
        float PowerdownPositionZ = Random.Range(0, 10);
        Vector3 randomPowerdown = new Vector3(PowerdownPositionX, 0.5f, PowerdownPositionZ);
        return randomPowerdown;
    }
    void Update()
    {
        count = FindObjectsOfType<SimpleCollectibleScript>().Length;
        powerCount = FindObjectsOfType<Rotate>().Length;
        powerDownCount = FindObjectsOfType<RotatePowerDown>().Length;
        if (powerDownCount == 0)
        {
            Instantiate(spawnPower.powerdownPrefab, SpawnPowerdown(), spawnPower.powerdownPrefab.transform.rotation);
        }
        if (count == 0)
        {
            Instantiate(diffi.coinPrefab, SpawnCoins(), diffi.coinPrefab.transform.rotation);
        }
        if (powerCount == 0)
        {
            Instantiate(spawnPower.powerupPrefab, SpawnPowerup(), spawnPower.powerupPrefab.transform.rotation);
        }
        if (gameOver == true)
        {
            time += Time.deltaTime;
            Debug.Log(time);
        }
        if (time > 2)
        {
            SceneManager.LoadScene(1);
        }
    }
    public void SpawnPos()
    {
        int cubeIndex = Random.Range(0, 2);
        int cubeIndexOne = Random.Range(2, 4);
        int cubeIndexTwo = Random.Range(4, 6);
        int cubeIndexThree = Random.Range(6, 8);
        int cubeIndexFour = Random.Range(8, prefab.Length);
        posOptions = Random.Range(1, 6);
        if (gameOver == false)
        {
            switch (posOptions)
            {
                case 1:
                    Instantiate(prefab[cubeIndex], new Vector3(-3.25f, 0.5f, posZ), prefab[cubeIndex].transform.rotation);
                    break;
                case 2:
                    Instantiate(prefab[cubeIndexOne], new Vector3(-1.5f, 0.5f, posZ), prefab[cubeIndex].transform.rotation);
                    break;
                case 3:
                    Instantiate(prefab[cubeIndexTwo], new Vector3(0.25f, 0.5f, posZ), prefab[cubeIndex].transform.rotation);
                    break;
                case 4:
                    Instantiate(prefab[cubeIndexThree], new Vector3(2.0f, 0.5f, posZ), prefab[cubeIndex].transform.rotation);
                    break;
                case 5:
                    Instantiate(prefab[cubeIndexFour], new Vector3(3.75f, 0.5f, posZ), prefab[cubeIndex].transform.rotation);
                    break;
                default:
                    break;
            }
        }
    }
}
