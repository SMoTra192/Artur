using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinSystem : MonoBehaviour
{
    public static float coinCount;
    [SerializeField] private Text coinText;

    private void Start()
    {
        coinText.text = GetComponent<Text>().text;
    }

    private void Update()
    {
        coinCount = PlayerPrefs.GetFloat("CoinScore");
        coinText.text = $"{coinCount}";
    }
}
