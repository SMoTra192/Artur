using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class ChangeColor : MonoBehaviour {

    [SerializeField] private Material m_material;
    
    private void Awake() {
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Color[] changeColor = {new Vector4(0.7490196f, 0.2784314f, 0.2705882f, 1f), 
                                    new Vector4(0.2431373f, 0.5490196f, 0.8235295f, 1f), 
                                    new Vector4(0.9215687f, 0.7372549f, 0.254902f, 1f),
                                    new Vector4(0.3843138f, 0.627451f, 0.5450981f, 1f)
            };
            int rnd = Random.Range(0, changeColor.Length);
            Color currentcolor = m_material.color;

            while (currentcolor == changeColor[rnd]) {
                rnd = Random.Range(0, changeColor.Length);
            }
            
            m_material.SetColor("_Color", changeColor[rnd]);
        }
    }
}
