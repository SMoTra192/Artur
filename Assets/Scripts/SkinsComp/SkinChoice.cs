using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SkinChoice : MonoBehaviour
{
    [SerializeField] private Image currentImage;
    [SerializeField] private Transform skinButtonHolder;
    [SerializeField] private GameObject skinChoiceWindow;
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
