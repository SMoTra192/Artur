using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private GameObject scoreText;
    
    public static int ScoreCount;
    void Update()
    {
        
        scoreText.GetComponent<Text>().text = " " + ScoreCount;
    }
}
