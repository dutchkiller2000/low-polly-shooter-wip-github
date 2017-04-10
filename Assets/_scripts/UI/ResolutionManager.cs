using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class ResolutionManager : MonoBehaviour
{
    public Dropdown dropDown;
    public Toggle toggle;
    public bool fullscreen;

    void Start()
    {
        dropDown.value = PlayerPrefs.GetInt("res");
		if(PlayerPrefs.GetInt("fullscreen") == 1){
			toggle.isOn = true;
		} else{
			toggle.isOn = false;
		}

        dropDown.value = PlayerPrefs.GetInt("res");
    }

    void Update()
    {
        if (toggle.isOn)
        {
            fullscreen = true;
            PlayerPrefs.SetInt("fullscreen", 1);
        }
        else
        {
            fullscreen = false;
            PlayerPrefs.SetInt("fullscreen", 0);

        }

        if (dropDown.value == 0)
        {
            //1280 X 600
            Screen.SetResolution(1280, 600, fullscreen);
            PlayerPrefs.SetInt("res", 0);
            
        }
        if (dropDown.value == 1)
        {
            //1280 x 720
            Screen.SetResolution(1280, 720, fullscreen);
            PlayerPrefs.SetInt("res", 1);
        }
        if (dropDown.value == 2)
        {
            //1280 x 1024
            Screen.SetResolution(1280, 1024, fullscreen);
            PlayerPrefs.SetInt("res", 2);
        }
        if (dropDown.value == 3)
        {
            //1360	 x 768
            Screen.SetResolution(1360, 768, fullscreen);
            PlayerPrefs.SetInt("res", 3);
        }
        if (dropDown.value == 4)
        {
            //1366 x 768
            Screen.SetResolution(1366, 768, fullscreen);
            PlayerPrefs.SetInt("res", 4);
        }
        if (dropDown.value == 5)
        {
            //1440 x 900
            Screen.SetResolution(1440, 900, fullscreen);
            PlayerPrefs.SetInt("res", 5);
        }
        if (dropDown.value == 6)
        {
            //1600 x 900
            Screen.SetResolution(1600, 900, fullscreen);
            PlayerPrefs.SetInt("res", 6);
        }
        if (dropDown.value == 7)
        {
            //1680 x 1050
            Screen.SetResolution(1680, 1050, fullscreen);
            PlayerPrefs.SetInt("res", 7);
        }
        if (dropDown.value == 8)
        {
            //1920 x 1080'
            Screen.SetResolution(1920, 1080, fullscreen);
            PlayerPrefs.SetInt("res", 8);
        }
        if (dropDown.value == 9)
        {
            //3840 x 2160
            Screen.SetResolution(3840, 2160, fullscreen);
            PlayerPrefs.SetInt("res", 9);
        }
        if (dropDown.value == 10)
        {
            //4096 x 2160
            Screen.SetResolution(4069, 2160, fullscreen);
            PlayerPrefs.SetInt("res", 10);
        }
    }
}
