using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class RandomScripts : MonoBehaviour
{
    public Text killCounterText;
    void Start()
    {
        PlayerPrefs.SetInt("zk", 0);
        killCounterText.text = "0";
    }

    void Update()
    {
    }
}
