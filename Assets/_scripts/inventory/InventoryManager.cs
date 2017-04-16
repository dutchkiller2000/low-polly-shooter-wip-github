using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class InventoryManager : MonoBehaviour {
	public GameObject[] invItems; // max 6(so 5 in inspector because 0 counts too)
	public RawImage[] thumpNail;
	BuyItemHandler buyItemHandler;
	void Start () {
		for (int i = 0; i < invItems.Length; i++)
		{
			invItems[1] = null;
		}

		 buyItemHandler = GameObject.Find("StoreTrigger").GetComponent<BuyItemHandler>();

	}
	
	void Update () {
		
	}
	public void ChangePicture0(){
		thumpNail[buyItemHandler.PlaceLoc].texture = buyItemHandler.ThumpNail[0];
	}
}
