using UnityEngine;

public class CollectNPS : MonoBehaviour
{
    [SerializeField] private int ScoreAmountMin,ScoreAmountMax;
    [SerializeField] private GameObject effect;
    
    private void OnTriggerEnter(Collider other)
    {
        Instantiate(effect, transform.position, Quaternion.identity);
        ScoreSystem.ScoreCount += Random.Range(ScoreAmountMin,ScoreAmountMax);
        Destroy(gameObject);
    }
}