using System;
using System.Collections;
using UnityEngine;

public class BuyHandler : MonoBehaviour {
    public GameObject[] buyableItems;
    public int[] price;
    public Texture[] thumpNails;
    InventoryManager inventoryManager;
    MoneyManager moneyManager;
    public GameObject notEnoughMoneyText;
	void Start () {
        inventoryManager = GameObject.Find("_scripts").GetComponent<InventoryManager>();
        moneyManager = GameObject.Find("_scripts").GetComponent<MoneyManager>();
        notEnoughMoneyText.SetActive(false);
    }
	
    public void BuyItem01()
    {
        if (moneyManager.CurrentMoney < price[0]) //verander 0
        {
            notEnoughMoneyText.SetActive(true);
            StartCoroutine(NNMTimer());
        }
        else
        {
            moneyManager.CurrentMoney = moneyManager.CurrentMoney - price[0];//change 0
            inventoryManager.inventoryItems[inventoryManager.freeSlot] = buyableItems[0];//change 0 to 1 if new item
            inventoryManager.rawImage[inventoryManager.freeSlot].texture = thumpNails[0];//change both 0
        }
        //check if has enough money
        //remove money
        //change thumpnail
        //add item
    }

    public void BuyItem02()
    {
        if (moneyManager.CurrentMoney < price[1]) //verander array
        {
            notEnoughMoneyText.SetActive(true);
            StartCoroutine(NNMTimer());
        }
        else
        {
            moneyManager.CurrentMoney = moneyManager.CurrentMoney - price[1];//change array
            inventoryManager.inventoryItems[inventoryManager.freeSlot] = buyableItems[1];//change array
            inventoryManager.rawImage[inventoryManager.freeSlot].texture = thumpNails[1];//change  array
        }
    }

    IEnumerator NNMTimer()
    {
        yield return new WaitForSeconds(3);
        notEnoughMoneyText.SetActive(false);
    }
}
