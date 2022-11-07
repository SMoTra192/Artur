using UnityEngine;
using UnityEngine.UI;

public class HealthCount : MonoBehaviour
{
    [SerializeField] private Text healthText;
    public static float healthCount;

    private void Start()
    {
        healthText.text = GetComponent<Text>().text;
    }

    void Update()
    {
        healthText.text = $"{healthCount}"; 
    }
}
