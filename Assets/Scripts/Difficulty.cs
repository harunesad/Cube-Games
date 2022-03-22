using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Difficulty : MonoBehaviour
{
    private SpawnManager spawnManager;
    private GameObject spawn;
    private GameObject two;
    public Text title;
    public Button easy, normal, hard;
    public GameObject coinPrefab;
    public float PosX;
    public float PosZ;
    void Start()
    {
        spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        spawn = GameObject.Find("SpawnManager");
        two = GameObject.Find("Two");
        PosX = Random.Range(-3.75f, 3.75f);
        PosZ = Random.Range(0, 10);
    }
    void Update()
    {
        
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
    //public void Restart()
    //{
    //    title.enabled = true;
    //    easy.gameObject.SetActive(true);
    //    normal.gameObject.SetActive(true);
    //    hard.gameObject.SetActive(true);
    //    restart.gameObject.SetActive(false);
    //}
}
