using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HealtManager : MonoBehaviour {
	deathManager DeathManager;
	public int maxHealth;
	public Slider healthSlider;
	public int currentHealth;
	void Start () {
		currentHealth = maxHealth;
		healthSlider.maxValue = maxHealth;
		healthSlider.value = maxHealth;
	}
	
	void Update () {
		healthSlider.value = currentHealth;
		if(currentHealth<=0){
			SceneManager.LoadScene("dead");
		}
	}
}
