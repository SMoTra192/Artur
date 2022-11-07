using System.Collections;
using UnityEngine;
public class HealthSystem : MonoBehaviour
    {
        [SerializeField] private float MaxHealth;
        private float curHealth;
        
        [SerializeField] private GameObject panel,gamepanel,damagePanel,Main;

        private void Start()
        {
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
                Main.SetActive(false);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                TakeDamage(1);
                if (HealthCount.healthCount >-1)
                StartCoroutine(DmgPanelActivity());
            }

        }

        IEnumerator DmgPanelActivity()
        {
            damagePanel.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            damagePanel.SetActive(false);
        }
    }
    
