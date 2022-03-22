using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePowerDown : MonoBehaviour
{
    private float speedRotateDown = 5;
    void Start()
    {

    }
    void Update()
    {
        gameObject.transform.Rotate(0, Time.deltaTime * speedRotateDown, 0);
    }
}
