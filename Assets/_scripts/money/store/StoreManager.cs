using System.Collections;
using UnityEngine;

public class StoreManager : MonoBehaviour
{
    public KeyCode openStore;
    [HideInInspector]
	public bool StoreOpen = false;
    void Start()
    {

    }

    void OnTriggerStay(Collider coll)
    {
        Debug.Log("collider works");
        if (coll.gameObject.tag == "Player")
        {
            //press e to open store tab
            Debug.Log("player can open store if press: " + openStore);
            if (Input.GetKeyDown(openStore))
            {

                StoreOpen = true;
            }
        }
        if (StoreOpen)
        {
            Debug.Log("store open");
            //pause game 
            // store gm enabled
			//ispause = true
        }
    }
}
