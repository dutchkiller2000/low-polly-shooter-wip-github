using System.Collections;
using UnityEngine;

public class StoreOpenerHandler : MonoBehaviour {
	public GameObject[] GMToDisn;
	void Start () {
		Time.timeScale = 0;
		for (int i = 0; i < GMToDisn.Length; i++)
		{
			GMToDisn[i].SetActive(false);
		}
	}
	
	void Update () {
		
	}
}
