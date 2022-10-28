using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI highScoreText;
    public static float ScoreCount;
    private float highScore, RestartScore = 0;

    
    void Update()
    {
        highScore = PlayerPrefs.GetFloat("HighScore");
        scoreText.GetComponent<TextMeshProUGUI>().text = " " + ScoreCount;
        highScoreText.GetComponent<TextMeshProUGUI>().text = " " + highScore;
        if (ScoreCount > highScore)
        {
            PlayerPrefs.SetFloat("HighScore", ScoreCount);
        }
Restart();
        
    }

    private void Restart()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
            PlayerPrefs.SetFloat("HighScore",RestartScore);
        }
    }
}


