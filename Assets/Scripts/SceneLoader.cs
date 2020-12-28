using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    //questi metodi vanno bene per ogni programma. l'indice delle scene non dipende dal programma perchè parto sempre e comunque da 0
    public void ProssimaScena()
    {
        SceneManager.LoadScene(1);      //ogni scena ha un indice. per passare da una all'altra aggiungo all'indice 1
    }

    public void PrimaScena()
    {
        SceneManager.LoadScene(0);
    }

    public void SecondaScena()
    {
        SceneManager.LoadScene(1);
    }

    public void TerzaScena()
    {
        SceneManager.LoadScene(2);
    }

    public void QuartaScena()
    {
        SceneManager.LoadScene(3);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
