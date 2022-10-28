using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    public TextMeshProUGUI score;
    private float gamescore;

    void Start()
    {
        gamescore = ScoreSystem.ScoreCount;
        score.text =("Score:") + (gamescore);
    }
}
