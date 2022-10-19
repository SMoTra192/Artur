using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CoinCount : MonoBehaviour
{
    [SerializeField] private int minCoinCount, maxCoinCount;
    private void OnTriggerEnter(Collider other)
    {
        CoinSystem.coinCount += Random.Range(minCoinCount,maxCoinCount);
        Destroy(gameObject);
    }
}
