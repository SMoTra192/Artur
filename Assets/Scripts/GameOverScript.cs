using TMPro;
using UnityEngine;
public class GameOverScript : MonoBehaviour
{
    public TextMeshProUGUI score;
    private float gamescore;

    void Start()
    {
        gamescore = ScoreSystem.ScoreCount;
        score.text =("Score:" + $"{gamescore}");
    }
}
