using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class SkinsInGame : MonoBehaviour
{
    private List<NewSkin> Skins = new List<NewSkin>();
    private List<Transform> Skinss = new List<Transform>();
    [SerializeField] private Transform playerSkinHolder,Position;
    [SerializeField] private GameObject Skin;
    

    private void Awake()
    {
        Skins.AddRange(playerSkinHolder.GetComponentsInChildren<NewSkin>());
        Skinss.AddRange(playerSkinHolder.GetComponentsInChildren<Transform>());
    }

    public void SkinOff()
    {
        Debug.Log("Desabling the Skins!");
        foreach (var skin in Skins)
        {
            skin.gameObject.SetActive(false);
        }
    }

    public void SetSkin()
    {
        Debug.Log("Setting The Skin!");
        Skin.SetActive(true);
        Skin.transform.position = Position.position;


    }
    


}
