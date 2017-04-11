using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class MoneyManager : MonoBehaviour
{
    public int StartCash;
    public int MoneyBody;
	public int MoneyLegs;
	public int MoneyArms;
	public int moneyHead;
    public int MoneyToAddBonus;
    public Text moneyText;
    [HeaderAttribute("some debug values, don't put anything here!")]
    public int CurrentMoney;
    void Start()
    {
        PlayerPrefs.SetInt("money", 0);
        CurrentMoney = StartCash;
    }

    void Update()
    {
        moneyText.text = CurrentMoney.ToString();
    }
    public void AddMoneyBody()
    {
        CurrentMoney = CurrentMoney + MoneyBody;
        PlayerPrefs.SetInt("money", CurrentMoney);
    }
    public void BonusMoney()
    {
        //can play animation here???
        CurrentMoney = CurrentMoney + MoneyToAddBonus;
        PlayerPrefs.SetInt("money", CurrentMoney);
    }
    public void AddMoneyLegs()
    {
        CurrentMoney = CurrentMoney + MoneyLegs;
        PlayerPrefs.SetInt("money", CurrentMoney);
    }
	    public void AddMoneyArms()
    {
        CurrentMoney = CurrentMoney + MoneyArms;
        PlayerPrefs.SetInt("money", CurrentMoney);
    }
		    public void AddMoneyHead()
    {
        CurrentMoney = CurrentMoney + moneyHead;
        PlayerPrefs.SetInt("money", CurrentMoney);
    }
	
}
