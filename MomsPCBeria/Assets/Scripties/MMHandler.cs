using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuHandler : MonoBehaviour
{
    public GameObject menu1;
    public GameObject menu2;
    public GameObject menu3;
    public GameObject PrevMenu;
    
    public void OnPressQuit()
    {
        Application.Quit();
    }

    public void SelMenu1()
    {
        SceneManager.LoadScene("Game");
    }

    public void SelMenu2()
    {
        menu2.SetActive(true);
        PrevMenu.SetActive(false);
    }

    public void SelMenu3()
    {
        menu3.SetActive(true);
        PrevMenu.SetActive(false);
    }

    public void SetFullscreen(bool fullscreen)
    {
        Screen.fullScreen = fullscreen;
    }




}
