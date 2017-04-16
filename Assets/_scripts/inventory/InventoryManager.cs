using System.Collections;
using UnityEngine;

public class InventoryManager : MonoBehaviour {
	public GameObject[] invItems; // max 6(so 5 in inspector because 0 counts too)
	void Start () {
		for (int i = 0; i < invItems.Length; i++)
		{
			invItems[1] = null;
		}
	}
	
	void Update () {
		
	}
}
