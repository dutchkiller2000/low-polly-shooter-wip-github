using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class ShadowsQuality : MonoBehaviour
{
    public Dropdown dropDown;

    void Start()
    {
        dropDown.value = PlayerPrefs.GetInt("sq");
    }

    void Update()
    {

        if (dropDown.value == 0)
        {
            QualitySettings.shadowResolution = ShadowResolution.VeryHigh;
            PlayerPrefs.SetInt("sq",0);
        }
        if (dropDown.value == 1)
        {
            QualitySettings.shadowResolution = ShadowResolution.High;
            PlayerPrefs.SetInt("sq", 1);
        }
        if (dropDown.value == 2)
        {
            QualitySettings.shadowResolution = ShadowResolution.Medium;
            PlayerPrefs.SetInt("sq", 2);
        }
        if (dropDown.value == 3)
        {
            QualitySettings.shadowResolution = ShadowResolution.Low;
            PlayerPrefs.SetInt("sq", 3);
        }
    }
}
