using UnityEngine;
public class SecretSpawner : MonoBehaviour
{
    [SerializeField] private GameObject SecretNPC;
    private GameObject Secret;
    [SerializeField] private Transform Parent;
    public GameObject spawnPoint;
    

    private void Update()
    {
        if (Collect.isTouched)
        {
            for (var i = 0; i < 2; i++)
            {
                GameObject Secret = Instantiate(SecretNPC, spawnPoint.transform.position, Quaternion.identity);
                Secret.transform.parent = Parent;
            }
            Collect.isTouched = false;
        }
    }

}
