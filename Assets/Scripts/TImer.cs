using System;
using System.Collections;
using System.Resources;
using System.Threading;
using TMPro;
using UnityEngine;

public class TImer : MonoBehaviour
{  
    private bool isCreated = false;
    private float _timer;
    [Header("Effects")]
    [SerializeField] private GameObject effect1, effect2;
    [SerializeField] private Transform effectPos1, effectPos2;
    [Header("Timer")]
    public float _timerduration = 3f * 60f;
    [SerializeField] private GameObject timePanel;
    [SerializeField]private TextMeshProUGUI _firstminute;
    [SerializeField]private TextMeshProUGUI _secondminute;
    [SerializeField]private TextMeshProUGUI _separator;
    [SerializeField]private TextMeshProUGUI _fisrtsecond;
    [SerializeField]private TextMeshProUGUI _secondsecond; 
    [Header("Other")] 
    [SerializeField] private GameObject Barrier,MainGame;
    


    public GameObject panel,gamepanel;
    void Start()
    {
        ResetTimer();
    }

    
    void Update()
    {
        if (_timer > 0)
        {
            _timer -= Time.deltaTime;
            UpdateDisplay(_timer);
        }
        else
        {
            Flash();
        }
        if (_timer <= 0)
        {
            gamepanel.SetActive(false);
            panel.SetActive(true);
            MainGame.SetActive(false);
        }

        if (_timer > 0 && _timer < 2f)
        {
            if (!isCreated)
            {
                Instantiate(effect1, effectPos1.transform.position, Quaternion.identity);
                Instantiate(effect2, effectPos2.transform.position, Quaternion.identity);
                Instantiate(effect1, effectPos1.transform.position, Quaternion.identity);
                Instantiate(effect2, effectPos2.transform.position, Quaternion.identity);
                isCreated = true;
            }
        }

        if (_timer < 20) timePanel.SetActive(true);
        if (_timer < 10)
        {
            timePanel.SetActive(false);
            Barrier.SetActive(false);
        }
            
    }

    private void ResetTimer()
    {
        _timer = _timerduration;
    }

    private void Flash()
    {}

    private void UpdateDisplay(float time)
    {
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);
        string currenttime = string.Format("{00:00}{1:00}", minutes, seconds);
        _firstminute.text = currenttime[0].ToString();
        _secondminute.text = currenttime[1].ToString();
        _fisrtsecond.text = currenttime[2].ToString();
        _secondsecond.text = currenttime[3].ToString();
        
    }
    
}
