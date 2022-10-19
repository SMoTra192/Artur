using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KristalCount : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        KristalSystem.kristalCount += 1;
        Destroy(gameObject);
    }
}
