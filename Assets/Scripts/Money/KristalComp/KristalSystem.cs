using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KristalSystem : MonoBehaviour
{
    [SerializeField] private GameObject kristalText;
    
    public static int kristalCount;
    void Update()
    {
        
        kristalText.GetComponent<Text>().text = " " + kristalCount;
    }
}
