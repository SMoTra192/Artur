using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    public Text score;
    private int gamescore;

    void Start()
    {
        gamescore = ScoreSystem.ScoreCount;
        score.text =("Score: ") + (gamescore);
    }
}
