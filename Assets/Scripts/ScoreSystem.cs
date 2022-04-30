using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public Text  highScoreText;
    public float highScoreCount;
    public SpawnManager spawnManage;
    public Difficulty dif;
    void Start()
    {
        if (PlayerPrefs.GetFloat("CubeHighScore") != null)
        {
            highScoreCount = PlayerPrefs.GetFloat("CubeHighScore");
        }
    }
    void Update()
    {
        if (spawnManage.point > highScoreCount)
        {
            highScoreCount = spawnManage.point;
            PlayerPrefs.SetFloat("CubeHighScore", highScoreCount);
        }
        highScoreText.text = "High Score: " + Mathf.Round(highScoreCount);
    }
}
