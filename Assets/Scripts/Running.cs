using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Running : MonoBehaviour
{
    [SerializeField] private Transform[] positions; 
    private Transform nextpos;
    [SerializeField] private float _speed;
    [SerializeField] private int NextposIndex;
    private void Start()
    {
        nextpos = positions[0];
    }

    void movegameobject()
    {
        if (transform.position == nextpos.position)
        {
            NextposIndex++;
            if (NextposIndex >= positions.Length)
            {
                NextposIndex = 0;
            }

            nextpos = positions[NextposIndex];
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, nextpos.position, _speed * Time.deltaTime);
        }
    }

    private void Update()
    {
        movegameobject();
    }
}
