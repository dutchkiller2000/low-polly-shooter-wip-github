using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class TextureQuality : MonoBehaviour
{
    public Dropdown dropDown;

    void Start()
    {
        dropDown.value = PlayerPrefs.GetInt("tq");
    }

    void Update()
    {

        if (dropDown.value == 0)
        {
            QualitySettings.masterTextureLimit = 0;
            PlayerPrefs.SetInt("tq", 0);

        }
        if (dropDown.value == 1)
        {
           QualitySettings.masterTextureLimit = 1;
            PlayerPrefs.SetInt("tq", 1);
        }
        if (dropDown.value == 2)
        {
            QualitySettings.masterTextureLimit = 2;
            PlayerPrefs.SetInt("tq", 2);
        }
        if (dropDown.value == 3)
        {
            QualitySettings.masterTextureLimit = 3;
            PlayerPrefs.SetInt("tq", 3);
        }
    }
}
