using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    [SerializeField] private int ScoreAmount;
    [SerializeField] private GameObject effect;
    public static bool isTouched = false;

    private void OnTriggerEnter(Collider other)
    {
        isTouched = true;
        Instantiate(effect, transform.position, Quaternion.identity);
        ScoreSystem.ScoreCount += ScoreAmount;
        Destroy(gameObject);
    }
}
