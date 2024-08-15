using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
public class MainMenuHandler : MonoBehaviour
{
    public AudioMixer mixer;
    public GameObject menu1;
    public GameObject menu2;
    public GameObject menu3;
    public GameObject PrevMenu;


    public TMP_Dropdown resolutionDropdown;

    Resolution[] resolutions;



    void Start()

    {

        resolutions = Screen.resolutions;



        resolutionDropdown.ClearOptions();



        List<string> options = new List<string>();



        int currentResolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)

        {

            string option = resolutions[i].width + "x" + resolutions[i].height + " " + resolutions[i].refreshRateRatio + " Hz";

            options.Add(option);



            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)

            {

                currentResolutionIndex = i;

            }

        }



        resolutionDropdown.AddOptions(options);

        resolutionDropdown.value = currentResolutionIndex;

        resolutionDropdown.RefreshShownValue();

    }



    public void SetResolution(int resolutionIndex)

    {

        Resolution resolution = resolutions[resolutionIndex];

        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);

    }


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

    public void Volume(float Volume)
    {
        mixer.SetFloat("volume", Volume);
    }




}
