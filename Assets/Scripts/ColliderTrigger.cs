using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(BoxCollider))]
public class ColliderTrigger : MonoBehaviour
{
   [SerializeField]private Material[] _materials;
   private Renderer rend;

   private void Start()
   {
      rend = GetComponent<Renderer>();
      rend.enabled = true;
      rend.sharedMaterial = _materials[0];
   }

   private void OnCollisionEnter(Collision collision)
   {
      if (collision.gameObject.CompareTag("Player"))
      {
         rend.sharedMaterial = _materials[1];
      }
   }
}
