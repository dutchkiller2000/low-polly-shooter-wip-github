using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class SetHighScoreZombiesKilled : MonoBehaviour {
	public Text highScoreZombieKilled;
	void Start () {
		if(PlayerPrefs.GetInt("zk") > PlayerPrefs.GetInt("hszk")){
			PlayerPrefs.SetInt("hszk",	PlayerPrefs.GetInt("zk"));
			Debug.Log("new highScore: " + PlayerPrefs.GetInt("hszk"));
		}
	}
	
	void Update () {
		
			highScoreZombieKilled.text = PlayerPrefs.GetInt("hszk").ToString();
	}
}
