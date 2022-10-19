using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class HealthSystem : MonoBehaviour
    {
        [SerializeField] private float MaxHealth;
        private float curHealth;
        [SerializeField] private float DamageAmount;
        [SerializeField] private GameObject panel,gamepanel;
        [SerializeField] private GameObject _enemy;

        private void Start()
        {
            curHealth = MaxHealth;
            
        }

        public void TakeDamage (int DamageAmount)
        {
            curHealth -= DamageAmount;
            if (curHealth == 0)
            {
                panel.SetActive(true);
                gamepanel.SetActive(false);
                gameObject.SetActive(false);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.CompareTag("Enemy")) TakeDamage(1);
        }
    }
    
