using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class ControladorPause : MonoBehaviour
{
    private bool isPaused;
    public GameObject PausePanel;
    public string cena;
    void Update()
    {
        if (!isPaused) { }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseScreen();
        }
    }
    void PauseScreen()
    {
        if (isPaused) { 
        isPaused = false;
            Time.timeScale = 1f;
        PausePanel.SetActive(false);}

        else { isPaused = true;
           Time.timeScale = 0f;
        PausePanel.SetActive(true);}
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(cena);
    }
}
