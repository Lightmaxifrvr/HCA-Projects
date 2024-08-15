using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public bool isPaused;
    public GameObject PauseMenu;
    public GameObject optionsmenu;
    public GameObject PauseCanvas;

    void Update()
    {    
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused == false)
            {
                isPaused = true;
                Time.timeScale = 0.0f;
                PauseCanvas.SetActive(true);
            }
            else if (isPaused == true)
            {
                Time.timeScale = 1.0f;
                PauseCanvas.SetActive(false);
                optionsmenu.SetActive(false);
                PauseMenu.SetActive(true);
                isPaused = false;
            }           
        }  
    }

    public void OnResume()
    {
        Time.timeScale = 1.0f;
        PauseCanvas.SetActive(false);
        optionsmenu.SetActive(false);
        PauseMenu.SetActive(true);
        isPaused = false;
    }

    public void OnMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Options()
    {
        optionsmenu.SetActive(true);
        PauseMenu.SetActive(false);
    }
}
