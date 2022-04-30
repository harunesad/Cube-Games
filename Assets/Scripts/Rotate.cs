using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private float speedRotate = 5;
    void Update()
    {
        RotateObject();
    }
    void RotateObject()
    {
        gameObject.transform.Rotate(0, Time.deltaTime * speedRotate, 0);
    }
}
