using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawnPoint;
    [SerializeField] private Transform parentGameObject;
    private int randPosition;
    public float startTimeBtwSpawns;
    private float timeBtwSpawns;
    
    void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
    }

    
    void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            
            randPosition = Random.Range(0, spawnPoint.Length);
            GameObject Enemy = Instantiate(enemy, spawnPoint[randPosition].transform.position, Quaternion.identity);
            Enemy.transform.parent = parentGameObject;
            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }

    

}
