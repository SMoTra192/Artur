using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinChoice : MonoBehaviour
{
    [SerializeField] private Image currentImage;
    [SerializeField] private Transform skinButtonHolder;
    [SerializeField] private List<SkinButton> _skinButton;
    private void Awake()
    {
        _skinButton.AddRange(skinButtonHolder.GetComponentsInChildren<SkinButton>());
        
        foreach (var button in _skinButton)
        {
            button.clicked.AddListener(s => currentImage.sprite = s);
        }
    }
}

    
    

