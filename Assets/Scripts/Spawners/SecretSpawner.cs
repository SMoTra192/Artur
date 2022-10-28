using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

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
            GameObject Secret = Instantiate(SecretNPC, spawnPoint.transform.position, Quaternion.identity);
            GameObject Secret2 = Instantiate(SecretNPC, spawnPoint.transform.position, Quaternion.identity);
            Secret.transform.parent = Parent;
            Secret2.transform.parent = Parent;
            Collect.isTouched = false;
        }
    }

}
