using UnityEngine;

public class KristalCount : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        PlayerPrefs.SetFloat("KeyScore",KristalSystem.KeyCount + 1f);
        Destroy(gameObject);
    }
}
