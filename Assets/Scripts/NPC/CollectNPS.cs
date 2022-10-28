using UnityEngine;

public class CollectNPS : MonoBehaviour
{
    [SerializeField] private int ScoreAmount;
    [SerializeField] private GameObject effect;
    
    private void OnTriggerEnter(Collider other)
    {
        Instantiate(effect, transform.position, Quaternion.identity);
        ScoreSystem.ScoreCount += ScoreAmount;
        Destroy(gameObject);
    }
}