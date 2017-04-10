using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class ShadowsDrawDistance : MonoBehaviour {
	public Slider Slider;
	void Start () {
		Slider.value = PlayerPrefs.GetInt("sdd");
	}
	
	void Update () {
			PlayerPrefs.SetInt("sdd",(int)Slider.value);
			QualitySettings.shadowDistance = Slider.value;
	}
}
