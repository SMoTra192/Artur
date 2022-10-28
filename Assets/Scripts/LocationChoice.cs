using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocationChoice : MonoBehaviour
{
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
        SceneManager.LoadScene("Skins");
    }
}
