using System.Collections;
using UnityEngine;

public class LoadSettingsManager : MonoBehaviour
{
    bool fullscreenRes;
    public GameObject fpsmeter;
    void Start()
    {


        if (PlayerPrefs.GetInt("fullscreen") == 1)
        { fullscreenRes = true; }
        else { fullscreenRes = false; }


        PlayerPrefs.GetInt("res");
        if (PlayerPrefs.GetInt("res") == 0)
        {
            Screen.SetResolution(1280, 600, fullscreenRes);
        }
        if (PlayerPrefs.GetInt("res") == 1)
        {
            Screen.SetResolution(1280, 720, fullscreenRes);
        }
        if (PlayerPrefs.GetInt("res") == 2)
        {
            Screen.SetResolution(1280, 1024, fullscreenRes);
        }
        if (PlayerPrefs.GetInt("res") == 3)
        {
            Screen.SetResolution(1360, 768, fullscreenRes);
        }
        if (PlayerPrefs.GetInt("res") == 4)
        {
            Screen.SetResolution(1366, 768, fullscreenRes);
        }
        if (PlayerPrefs.GetInt("res") == 5)
        {
            Screen.SetResolution(1440, 900, fullscreenRes);
        }
        if (PlayerPrefs.GetInt("res") == 6)
        {
            Screen.SetResolution(1600, 900, fullscreenRes);
        }
        if (PlayerPrefs.GetInt("res") == 7)
        {
            Screen.SetResolution(1680, 1050, fullscreenRes);
        }
        if (PlayerPrefs.GetInt("res") == 8)
        {
            Screen.SetResolution(1920, 1080, fullscreenRes);
        }
        if (PlayerPrefs.GetInt("res") == 9)
        {
            Screen.SetResolution(3840, 2160, fullscreenRes);
        }
        if (PlayerPrefs.GetInt("res") == 10)
        {
            Screen.SetResolution(4069, 2160, fullscreenRes);
        }


        //fps meter
        if (PlayerPrefs.GetInt("fpsMeter") == 1)
        {
            fpsmeter.SetActive(true);
        }
        else
        {
            fpsmeter.SetActive(false);
        }

        //vSyncCount
        if (PlayerPrefs.GetInt("refr") == 1)
        {
            QualitySettings.vSyncCount = 1;
        }
        else
        {
            QualitySettings.vSyncCount = 0;
        }
        //advanced settingsa 
        if (PlayerPrefs.GetInt("tq") == 0)
        {
            QualitySettings.masterTextureLimit = 0;
        }
        if (PlayerPrefs.GetInt("tq") == 1)
        {
            QualitySettings.masterTextureLimit = 1;
        }     if (PlayerPrefs.GetInt("tq") == 2)
        {
            QualitySettings.masterTextureLimit = 2;
        }
             if (PlayerPrefs.GetInt("tq") == 3)
        {
            QualitySettings.masterTextureLimit = 3;
        }



    }

    void Update()
    {

    }
}
