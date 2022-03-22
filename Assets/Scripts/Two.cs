using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two : MonoBehaviour
{
    public GameObject[] cube;
    public GameObject[] cubeTransform;
    private float posZ = -3.5f;
    private float positionZ = -3.0f;
    private float spawnPosZ = -1.5f;
    private SpawnManager spawn;
    void Start()
    {
        spawn = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }
    void Update()
    {
        SpawnClone();
    }
    public void SpawnClone()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit raycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out raycastHit, 10))
            {
                if (raycastHit.transform != null)
                {
                    if (spawn.gameOver == false)
                    {
                        if (raycastHit.transform.tag == "Two")
                        {
                            if (cubeTransform[0].transform.position.z > posZ)
                            {
                                Instantiate(cube[0], new Vector3(-3.25f, 0.5f, spawnPosZ), transform.rotation);
                            }
                            else
                            {
                                cubeTransform[5].transform.position = new Vector3(-3.25f, 0.5f, -4.75f);
                                cubeTransform[0].transform.position = new Vector3(-3.25f, 0.5f, positionZ);
                            }
                        }
                        if (raycastHit.transform.tag == "TwoTwo")
                        {
                            if (cubeTransform[1].transform.position.z > posZ)
                            {
                                Instantiate(cube[1], new Vector3(-1.5f, 0.5f, spawnPosZ), transform.rotation);
                            }
                            else
                            {
                                cubeTransform[6].transform.position = new Vector3(-1.5f, 0.5f, -4.75f);
                                cubeTransform[1].transform.position = new Vector3(-1.5f, 0.5f, positionZ);
                            }
                        }
                        if (raycastHit.transform.tag == "TwoThree")
                        {
                            if (cubeTransform[2].transform.position.z > posZ)
                            {
                                Instantiate(cube[2], new Vector3(0.25f, 0.5f, spawnPosZ), transform.rotation);
                            }
                            else
                            {
                                cubeTransform[7].transform.position = new Vector3(0.25f, 0.5f, -4.75f);
                                cubeTransform[2].transform.position = new Vector3(0.25f, 0.5f, positionZ);
                            }
                        }
                        if (raycastHit.transform.tag == "TwoFour")
                        {
                            if (cubeTransform[3].transform.position.z > posZ)
                            {
                                Instantiate(cube[3], new Vector3(2.0f, 0.5f, spawnPosZ), transform.rotation);
                            }
                            else
                            {
                                cubeTransform[8].transform.position = new Vector3(2.0f, 0.5f, -4.75f);
                                cubeTransform[3].transform.position = new Vector3(2.0f, 0.5f, positionZ);
                            }
                        }
                        if (raycastHit.transform.tag == "TwoFive")
                        {
                            if (cubeTransform[4].transform.position.z > posZ)
                            {
                                Instantiate(cube[4], new Vector3(3.75f, 0.5f, spawnPosZ), transform.rotation);
                            }
                            else
                            {
                                cubeTransform[9].transform.position = new Vector3(3.75f, 0.5f, -4.75f);
                                cubeTransform[4].transform.position = new Vector3(3.75f, 0.5f, positionZ);
                            }
                        }
                        if (raycastHit.transform.tag == "TwoSix")
                        {
                            if (cubeTransform[5].transform.position.z > posZ)
                            {
                                Instantiate(cube[5], new Vector3(-3.25f, 0.5f, spawnPosZ), transform.rotation);
                            }
                            else
                            {
                                cubeTransform[0].transform.position = new Vector3(-3.25f, 0.5f, -4.75f);
                                cubeTransform[5].transform.position = new Vector3(-3.25f, 0.5f, positionZ);
                            }
                        }
                        if (raycastHit.transform.tag == "TwoSeven")
                        {
                            if (cubeTransform[6].transform.position.z > posZ)
                            {
                                Instantiate(cube[6], new Vector3(-1.5f, 0.5f, spawnPosZ), transform.rotation);
                            }
                            else
                            {
                                cubeTransform[1].transform.position = new Vector3(-1.5f, 0.5f, -4.75f);
                                cubeTransform[6].transform.position = new Vector3(-1.5f, 0.5f, positionZ);
                            }
                        }
                        if (raycastHit.transform.tag == "TwoEight")
                        {
                            if (cubeTransform[7].transform.position.z > posZ)
                            {
                                Instantiate(cube[7], new Vector3(0.25f, 0.5f, spawnPosZ), transform.rotation);
                            }
                            else
                            {
                                cubeTransform[2].transform.position = new Vector3(0.25f, 0.5f, -4.75f);
                                cubeTransform[7].transform.position = new Vector3(0.25f, 0.5f, positionZ);
                            }
                        }
                        if (raycastHit.transform.tag == "TwoNine")
                        {
                            if (cubeTransform[8].transform.position.z > posZ)
                            {
                                Instantiate(cube[8], new Vector3(2.0f, 0.5f, spawnPosZ), transform.rotation);
                            }
                            else
                            {
                                cubeTransform[3].transform.position = new Vector3(2.0f, 0.5f, -4.75f);
                                cubeTransform[8].transform.position = new Vector3(2.0f, 0.5f, positionZ);
                            }
                        }
                        if (raycastHit.transform.tag == "TwoTen")
                        {
                            if (cubeTransform[9].transform.position.z > posZ)
                            {
                                Instantiate(cube[9], new Vector3(3.75f, 0.5f, spawnPosZ), transform.rotation);
                            }
                            else
                            {
                                cubeTransform[4].transform.position = new Vector3(3.75f, 0.5f, -4.75f);
                                cubeTransform[9].transform.position = new Vector3(3.75f, 0.5f, positionZ);
                            }
                        }
                    }                 
                }
            }
        }
    }
}
