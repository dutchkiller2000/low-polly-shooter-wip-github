using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class antiAliasing : MonoBehaviour
{
    public Dropdown dropDown;

    void Start()
    {
        dropDown.value = PlayerPrefs.GetInt("aa");
    }

    void Update()
    {

        if (dropDown.value == 0)
        {
            QualitySettings.antiAliasing = 0;
            PlayerPrefs.SetInt("aa", 0);

        }
        if (dropDown.value == 1)
        {
           QualitySettings.antiAliasing = 2;
            PlayerPrefs.SetInt("aa", 1);
        }
        if (dropDown.value == 2)
        {
            QualitySettings.antiAliasing = 4;
            PlayerPrefs.SetInt("aa", 2);
        }
        if (dropDown.value == 3)
        {
            QualitySettings.antiAliasing = 8;
            PlayerPrefs.SetInt("aa", 3);
        }
    }
}
