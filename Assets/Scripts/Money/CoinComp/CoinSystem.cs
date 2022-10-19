using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinSystem : MonoBehaviour
{
    public static float coinCount;
    [SerializeField] private GameObject coinText;

    private void Update()
    {
        coinText.GetComponent<Text>().text = " " + coinCount;
    }
}
