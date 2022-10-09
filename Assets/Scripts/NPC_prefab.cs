using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
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
    private Rigidbody _rigidbody;
    private Renderer _renderer;
    private Color mycolor;
    private Material myMaterial;
    private int ColorNumber;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _renderer = GetComponent<Renderer>();
        myMaterial = _renderer.material;
    }
    void Update()
    {
        ColorNumber = Random.Range(0, _colorss.Length);
        myMaterial.color  = _colorss[ColorNumber];
        StartCoroutine(ColorChange());
        
    }

    // Update is called once per frame
    private IEnumerator ColorChange()
    {
        
        yield return new WaitForSeconds(2);
        
    }
}
