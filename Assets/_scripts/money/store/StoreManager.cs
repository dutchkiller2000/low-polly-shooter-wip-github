using System.Collections;
using UnityEngine;

public class StoreManager : MonoBehaviour {
	public KeyCode openStore;
	bool StoreOpen = false;
	void Start () {
		
	}
	
	void OnTriggerStay (Collider coll) {
		Debug.Log("collider works");
		if(coll.gameObject.tag == "Player"){
			//press e to open store tab
			Debug.Log("player can open store if press: " + openStore );
			if(Input.GetKeyDown(openStore)){
				Debug.Log("store open");
				//pause game 
				// store gm enabled
				StoreOpen=true;
			}
		}
	}
}
