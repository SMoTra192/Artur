using System;
using System.Collections;
using System.Resources;
using TMPro;
using UnityEngine;

public class TImer : MonoBehaviour
{
    public float _timerduration = 3f * 60f;
    private float _timer;
    [SerializeField] private GameObject effect1, effect2;
    [SerializeField]private Transform effectPos1, effectPos2;
    private bool isCreated = false;
    [SerializeField]private TextMeshProUGUI _firstminute;
    [SerializeField]private TextMeshProUGUI _secondminute;
    [SerializeField]private TextMeshProUGUI _separator;
    [SerializeField]private TextMeshProUGUI _fisrtsecond;
    [SerializeField]private TextMeshProUGUI _secondsecond;


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
        }

        if (_timer > 0 && _timer < 1f)
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
