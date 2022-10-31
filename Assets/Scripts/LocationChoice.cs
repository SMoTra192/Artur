using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocationChoice : MonoBehaviour
{
    [SerializeField] private GameObject Main,SkinWindow;
    public void OnSceneMenuClick()
    {
        SceneManager.LoadScene("Menu");
    }

    public void OnSceneCityClick()
    {
        SceneManager.LoadScene("City");
    }

    public void OnSceneSkinsClick()
    {
        Main.SetActive(false);
        SkinWindow.SetActive(true);
    }

    public void BackToScene()
    {
        Main.SetActive(true);
        SkinWindow.SetActive(false);
    }
    
}
