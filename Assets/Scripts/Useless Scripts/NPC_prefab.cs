using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class NPC_prefab : MonoBehaviour
{
    [SerializeField] private Color[] _colorss = { 
        Color.black, 
        Color.blue,
        Color.cyan,
        Color.red,
        Color.green,
        Color.white,
        Color.gray,};
    private Renderer _renderer;
    private Color mycolor;
    private Material myMaterial;
    private int ColorNumber;
    void Start()
    {
        
        _renderer = GetComponent<Renderer>();
        myMaterial = _renderer.material;
    }

    private void Update()
    {
        ColorNumber = Random.Range(0, _colorss.Length);
    }

    private void OnEnable()
    {
        myMaterial.color  = _colorss[ColorNumber];
    }
}
