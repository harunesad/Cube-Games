using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeTwo : MonoBehaviour
{
    private Vector3 ftp;
    private Vector3 ltp;
    private float dragDistance;
    private Vector3 fark;
    private Two two;
    public Vector3 tempPosition;
    public Vector3 tempPositionTwo;
    //public Text text;
    void Start()
    {
        two = GameObject.Find("Two").GetComponent<Two>();
        //dragDistance = Screen.height * 15 / 100;
    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.touches[0];
            if (touch.phase == TouchPhase.Began)
            {
                ftp = touch.position;
                ltp = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                ltp = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                ltp = touch.position;
                if (Mathf.Abs(ltp.x - ftp.x) > dragDistance || Mathf.Abs(ltp.y - ftp.y) > dragDistance)
                {
                    if ((Mathf.Abs(ltp.x - ftp.x) < Mathf.Abs(ltp.y - ftp.y)))
                    {
                        if (ltp.y > ftp.y)
                        {
                           
                        }
                    }
                }
            }
        }
    }
    private void OnMouseDown()
    {
        fark = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
    }
    private void OnMouseUp()
    {
        print(Input.mousePosition.x);
        print(Mathf.Abs(transform.position.x * 100));
        if (Input.mousePosition.x - Mathf.Abs(transform.position.x) * 100 > 5 && Input.mousePosition.x - Mathf.Abs(transform.position.x) * 100 < 27)
        {
            tempPosition = two.cubeTransform[0].transform.position;
            tempPositionTwo = two.cubeTransform[1].transform.position;
            two.cubeTransform[0].transform.position = tempPositionTwo;
            two.cubeTransform[1].transform.position = tempPosition;
        }
        if (Input.mousePosition.x > 375 && Input.mousePosition.x < 415)
        {
            transform.position = new Vector3(0.25f, 0.5f, -3);
            two.cubeTransform[2].transform.position = new Vector3(-3.25f, 0.5f, -3);
        }
    }
}
