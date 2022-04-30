using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePowerDown : MonoBehaviour
{
    private float speedRotateDown = 5;
    void Update()
    {
        RotatePower();
    }
    void RotatePower()
    {
        gameObject.transform.Rotate(0, Time.deltaTime * speedRotateDown, 0);
    }
}
