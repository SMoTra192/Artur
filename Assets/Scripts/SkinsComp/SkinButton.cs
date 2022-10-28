using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SkinButton : MonoBehaviour , IPointerClickHandler
{
    [SerializeField] private Button button;
    public UnityEvent<Sprite> clicked = new();
    [SerializeField] private Image image;

    private void Awake()
    {
        void EnsureNotNull(object something)
        {
            if (something == null)
            {
                throw new ApplicationException();
            }
        }
        EnsureNotNull(button);
        EnsureNotNull(image);
    }

    void Start()
    {
        button.onClick.AddListener(HandleClick);
    }

    private void HandleClick()
    {
        clicked?.Invoke(image.sprite);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        HandleClick();
    }
}
