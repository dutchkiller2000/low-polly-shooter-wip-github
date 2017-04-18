using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class VolumeManager : MonoBehaviour {
	public Slider volumeSlider;
	public Text procentText;
	AudioListener AudioListener;
	void Start () {
		AudioListener = Camera.main.GetComponent<AudioListener>(); 
		volumeSlider.value = PlayerPrefs.GetInt("volume");
	}
	
	void Update () {
		SetProcent();
		SetVolume();
	}
	public void SetProcent(){
		procentText.text = volumeSlider.value / 10 + "%";
	}
	public void SetVolume(){
		AudioListener.volume = volumeSlider.value;
		PlayerPrefs.SetInt("volume",Mathf.FloorToInt( volumeSlider.value)/100);
	}
}
