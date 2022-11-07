using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
#nullable enable
public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText = null!;
    [SerializeField] private TextMeshProUGUI highScoreText = null!;
    public static float ScoreCount;
    private float highScore, RestartScore = 0;
    private static string HighScore = null!;

    private void Start()
    {
        scoreText.text = GetComponent<TextMeshProUGUI>().text = $"{ScoreCount}";
        highScoreText.text = GetComponent<TextMeshProUGUI>().text = $"{highScore}";
        HighScore = "HighScore";
    }

    void Update()
    {
        highScore = PlayerPrefs.GetFloat(HighScore);
        scoreText.text = $"{ScoreCount}";
        highScoreText.text = $"{highScore}";
        if (ScoreCount > highScore)
        {
            PlayerPrefs.SetFloat(HighScore, ScoreCount);
        }
Restart();
        
    }

    private void Restart()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
            PlayerPrefs.SetFloat(HighScore,RestartScore);
        }
    }
}


