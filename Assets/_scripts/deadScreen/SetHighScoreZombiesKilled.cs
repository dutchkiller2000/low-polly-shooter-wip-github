using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class SetHighScoreZombiesKilled : MonoBehaviour {
	public Text highScoreZombieKilled;
	public Text moneyText;
	void Start () {
		if(PlayerPrefs.GetInt("zk") > PlayerPrefs.GetInt("hszk")){
			PlayerPrefs.SetInt("hszk",	PlayerPrefs.GetInt("zk"));
			Debug.Log("new highScore: " + PlayerPrefs.GetInt("hszk"));
		}
	}
	
	void Update () {
		
			highScoreZombieKilled.text = PlayerPrefs.GetInt("hszk").ToString();
			moneyText.text = PlayerPrefs.GetInt("money").ToString();
	}
}