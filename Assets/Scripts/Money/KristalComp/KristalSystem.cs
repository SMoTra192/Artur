using UnityEngine;
using UnityEngine.UI;

public class KristalSystem : MonoBehaviour
{
    [SerializeField] private Text keyText;
    public static float KeyCount;
    public static string KeyScore;

    private void Start()
    {
        keyText.text = GetComponent<Text>().text;
        KeyScore = "KeyScore";
    }

    void Update()
    {
        KeyCount = PlayerPrefs.GetFloat("KeyScore");
        keyText.text = $"{KeyCount}";
    }
}
