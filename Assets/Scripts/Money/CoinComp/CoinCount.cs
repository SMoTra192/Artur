using UnityEngine;
using Random = UnityEngine.Random;

public class CoinCount : MonoBehaviour
{
    [SerializeField] private int minCoinCount, maxCoinCount;
    private void OnTriggerEnter(Collider other)
    {
        PlayerPrefs.SetFloat("CoinScore",CoinSystem.coinCount += Random.Range(minCoinCount,maxCoinCount));
        Destroy(gameObject);
    }
}
