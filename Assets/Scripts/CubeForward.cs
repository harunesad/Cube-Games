using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeForward : MonoBehaviour
{
    private float limitZ = 10.5f;
    private SpawnManager spawnMan;
    private Difficulty difficult;
    private SpawnPower spawnPow;
    void Start()
    {
        spawnPow = GameObject.Find("SpawnPower").GetComponent<SpawnPower>();
        spawnMan = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        difficult = GameObject.Find("Difficulty").GetComponent<Difficulty>();
    }
    void Update()
    {
        if (spawnMan.gameOver == false)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * spawnMan.forwardSpeed);
        }
        if (gameObject.transform.position.z > limitZ)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("two") && gameObject.CompareTag("two"))
        {
            PointAdd();
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("twosix") && gameObject.CompareTag("two"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("twotwo") && gameObject.CompareTag("twotwo"))
        {
            PointAdd();
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("twoseven") && gameObject.CompareTag("twotwo"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("twothree") && gameObject.CompareTag("twothree"))
        {
            PointAdd();
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("twoeight") && gameObject.CompareTag("twothree"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("twofour") && gameObject.CompareTag("twofour"))
        {
            PointAdd();
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("twonine") && gameObject.CompareTag("twofour"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("twofive") && gameObject.CompareTag("twofive"))
        {
            PointAdd();
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("twoten") && gameObject.CompareTag("twofive"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("twosix") && gameObject.CompareTag("twosix"))
        {
            PointAdd();
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("two") && gameObject.CompareTag("twosix"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("twoseven") && gameObject.CompareTag("twoseven"))
        {
            PointAdd();
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("twotwo") && gameObject.CompareTag("twoseven"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("twoeight") && gameObject.CompareTag("twoeight"))
        {
            PointAdd();
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("twothree") && gameObject.CompareTag("twoeight"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("twonine") && gameObject.CompareTag("twonine"))
        {
            PointAdd();
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("twofour") && gameObject.CompareTag("twonine"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("twoten") && gameObject.CompareTag("twoten"))
        {
            PointAdd();
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("twofive") && gameObject.CompareTag("twoten"))
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            PointAdd();
        }
        if (other.gameObject.CompareTag("Powerup"))
        {
            Destroy(other.gameObject);
            spawnPow.SpawnPowerup();
        }
        if (other.gameObject.CompareTag("Powerdown"))
        {
            Destroy(other.gameObject);
            spawnPow.Spawndown();
        }
    }
    public void PointAdd()
    {
        spawnMan.point += 10;
        spawnMan.skor.text = "Point: " + Mathf.Round(spawnMan.point);
    }
}
