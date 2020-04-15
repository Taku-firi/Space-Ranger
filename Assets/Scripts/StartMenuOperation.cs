using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuOperation : MonoBehaviour
{
    public GameObject aboutinfo;


    public void StartMainGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1.0f;
    }

    public void ShowAbout()
    {
        aboutinfo.SetActive(true);
    }

    public void CloseAbout()
    {
        aboutinfo.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
