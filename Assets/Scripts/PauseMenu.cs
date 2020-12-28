using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GiocoInPausa = false;
    public GameObject pausemenuUI;
    public GameObject pauseButton;
    public GameSession gameSession;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GiocoInPausa)
            {
                Riprendi();
            }
            else
            {
                Pausa();
            }
        }
    }

    public void Riprendi()
    {
        pausemenuUI.SetActive(false);
        Time.timeScale = 1f;
        GiocoInPausa = false;
    }

    public void Pausa()
    {
        pausemenuUI.SetActive(true);
        Time.timeScale = 0f;
        GiocoInPausa = true;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
