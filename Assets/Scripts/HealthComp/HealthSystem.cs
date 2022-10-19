using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class HealthSystem : MonoBehaviour
    {
        [SerializeField] private float MaxHealth;
        private float curHealth;
        
        [SerializeField] private GameObject panel,gamepanel;

        private void Start()
        {
            //curHealth = MaxHealth;
            HealthCount.healthCount = MaxHealth;
        }

        public void TakeDamage (int DamageAmount)
        {
            HealthCount.healthCount -= DamageAmount;
            if (HealthCount.healthCount == 0)
            {
                panel.SetActive(true);
                gamepanel.SetActive(false);
                gameObject.SetActive(false);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Enemy"))
                TakeDamage(1);

            
        }
    }
    
