using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class BtnManager : MonoBehaviour
{
    public GameObject mainMenuUI;
    public GameObject levelPickerUI;
    public GameObject optionsUI;
    public GameObject fpsCounter;
    public GameObject ingameSettingsGm;
    [HeaderAttribute("toggles")]
    public Toggle vSync;
    public Toggle fpsMeterToggle;
    void Start()
    {
        if (SceneManager.GetActiveScene().name != "testScene" && SceneManager.GetActiveScene().name != "dead")
        {

            if (PlayerPrefs.GetInt("fpsMeter") == 1)
            {
                fpsMeterToggle.isOn = true;
            }
            else
            {
                fpsMeterToggle.isOn = false;
            }
            if (PlayerPrefs.GetInt("refr") == 1)
            {
                vSync.isOn = true;
            }
            else
            {
                vSync.isOn = false;
                fpsMeter();
            }
        }

    }

    public void LevelPicker()
    {
        mainMenuUI.SetActive(false);
        levelPickerUI.SetActive(true);
    }
    public void Options()
    {
        mainMenuUI.SetActive(false);
        optionsUI.SetActive(true);
    }


    public void Quit()
    {
        Application.Quit();
    }
    public void BackToMainMenu()
    {
        if (SceneManager.GetActiveScene().name == "UI")
        {

            levelPickerUI.SetActive(false);
            optionsUI.SetActive(false);
            mainMenuUI.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene("UI");
        }
    }
    public void LevelPickerTestLevel()
    {
        SceneManager.LoadScene("testScene");
    }
    public void VSync()
    {
        if (vSync.isOn)
        {
            QualitySettings.vSyncCount = 1;
            PlayerPrefs.SetInt("refr", 1);
        }
        else
        {
            QualitySettings.vSyncCount = 0;
            PlayerPrefs.SetInt("refr", 0);

        }
    }
    public void fpsMeter()
    {
        if (fpsMeterToggle.isOn)
        {
            fpsCounter.SetActive(true);
            PlayerPrefs.SetInt("fpsMeter", 1);
        }
        else
        {
            fpsCounter.SetActive(false);
            PlayerPrefs.SetInt("fpsMeter", 0);

        }
    }
    public void ingameSettings(){
        ingameSettingsGm.SetActive(true);
    }
    public void ingameBackToPauseScreen(){
        ingameSettingsGm.SetActive(false);
    }
}
