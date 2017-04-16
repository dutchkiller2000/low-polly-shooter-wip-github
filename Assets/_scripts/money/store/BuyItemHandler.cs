using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class BuyItemHandler : MonoBehaviour
{
    MoneyManager moneyManager;
	InventoryManager inventory;
    public Text SoldText;
    public Text[] itemNames;
    public int[] prices;
	public GameObject[] items;
    void Start()
    {
        moneyManager = GameObject.Find("_scripts").GetComponent<MoneyManager>();
        inventory = GameObject.Find("_scripts").GetComponent<InventoryManager>();
	    SoldText.text = "";

    }

    void Update()
    {

    }
    public void BuyItem1()
    {
        //show text item w/ name sold
        //remove money
        if (moneyManager.CurrentMoney >= prices[0])
        {
            moneyManager.CurrentMoney = moneyManager.CurrentMoney - prices[0];
            SoldText.text = "New item added to your inventory: " + itemNames[0].name;
			inventory.invItems[0] = items[0];
			Debug.Log(inventory.invItems[0].name);
	    }
        else
        {
			int over =  prices[0] - moneyManager.CurrentMoney;
			SoldText.color = Color.red;
			SoldText.text = "Not enough money, you need: $" + over + " more";
			StartCoroutine(ResetSoldText());
        }
        //add item to inventory

    }
	IEnumerator ResetSoldText(){
		yield return new WaitForSeconds(4);
		SoldText.color = Color.black;
		SoldText.text = "";
	}
}
