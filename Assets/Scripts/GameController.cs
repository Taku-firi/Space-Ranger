using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private bool pauseActive;
    public GameObject pause_menu;
    public GameObject gameover1;
    public GameObject gameover2;
    public GameObject gameover3;
    public GameObject win;
    public GameObject bgm;
    // Start is called before the first frame update
    void Start()
    {
        pauseActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PauseGame();
        }

        if(Counter.Instance.GetScore() >= 100)
        {
            Win();
        }

    }


    public void PauseGame()
    {
        pauseActive = !pauseActive;
        if(pauseActive == true)
        {
            Time.timeScale = 0.0f;
            pause_menu.SetActive(true);
        }
        else
        {
            Time.timeScale = 1.0f;
            pause_menu.SetActive(false);
        }
    }

    public void GameOver1()
    {
        Time.timeScale = 0.0f;
        gameover1.SetActive(true);
        bgm.GetComponent<RandomBGM>().setBack();
    }
    public void Gameover2()
    {
        Time.timeScale = 0.0f;
        gameover2.SetActive(true);
        bgm.GetComponent<RandomBGM>().setBack();
    }

    public void Gameover3()
    {
        Time.timeScale = 0.0f;
        gameover3.SetActive(true);
        bgm.GetComponent<RandomBGM>().setBack();
    }

    public void Win()
    {
        Time.timeScale = 0.0f;
        win.SetActive(true);
        bgm.GetComponent<RandomBGM>().setBack();
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

