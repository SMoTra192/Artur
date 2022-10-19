using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthCount : MonoBehaviour
{
    [SerializeField] private GameObject healthText;
    public static float healthCount;
    
    void Update()
    {
        healthText.GetComponent<Text>().text = " " + healthCount; 
    }
}
