using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Difficulty : MonoBehaviour
{
    public SpawnManager spawnManager;
    public GameObject spawn;
    public GameObject two;
    public Text title;
    public Button easy, normal, hard;
    public GameObject coinPrefab;
    public float PosX;
    public float PosZ;
    void Start()
    {
        PosX = Random.Range(-3.75f, 3.75f);
        PosZ = Random.Range(0, 10);
    }
    public void Easy()
    {
        spawn.GetComponent<SpawnManager>().enabled = true;
        two.GetComponent<Two>().enabled = true;
        spawnManager.gameOver = false;
        title.enabled = false;
        easy.gameObject.SetActive(false);
        normal.gameObject.SetActive(false);
        hard.gameObject.SetActive(false);
        Instantiate(coinPrefab, new Vector3(PosX, 0.5f, PosZ) , coinPrefab.transform.rotation);
        spawnManager.repeat = 0.75f;
        spawnManager.speed = 6;
        spawnManager.forwardSpeed = 6.0f;
    }
    public void Normal()
    {
        spawn.GetComponent<SpawnManager>().enabled = true;
        two.GetComponent<Two>().enabled = true;
        spawnManager.gameOver = false;
        title.enabled = false;
        easy.gameObject.SetActive(false);
        normal.gameObject.SetActive(false);
        hard.gameObject.SetActive(false);
        Instantiate(coinPrefab, new Vector3(PosX, 0.5f, PosZ), coinPrefab.transform.rotation);
        spawnManager.repeat = 0.65f;
        spawnManager.speed = 7;
        spawnManager.forwardSpeed = 7.0f;
    }
    public void Hard()
    {
        spawn.GetComponent<SpawnManager>().enabled = true;
        two.GetComponent<Two>().enabled = true;
        spawnManager.gameOver = false;
        title.enabled = false;
        easy.gameObject.SetActive(false);
        normal.gameObject.SetActive(false);
        hard.gameObject.SetActive(false);
        Instantiate(coinPrefab, new Vector3(PosX, 0.5f, PosZ), coinPrefab.transform.rotation);
        spawnManager.repeat = 0.5f;
        spawnManager.speed = 8;
        spawnManager.forwardSpeed = 8.0f;
    }
}
