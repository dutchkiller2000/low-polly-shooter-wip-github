using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using System;
public class ConsoleManager : MonoBehaviour
{
    public GameObject InputFieldGM;
    [HideInInspector]
    public bool chatOpen = false;
    public KeyCode keycode;
    [HeaderAttribute("error message if command not found")]
    public GameObject errorMes;
    public InputField InputField;
    FirstPersonController firstPersonController;
    AmmoManagerReloaded ammoManager;
    HealtManager healthManager;
    MoneyManager moneyManager;
    bool godMode;
    string typedText;
    [HeaderAttribute("spawning items under here")]
    public GameObject barrel;
    [HeaderAttribute("extra gm that need to be disnabled when console is open")]
    public GameObject healthBar;
    public GameObject AmmoGUI;
    ConsoleManager consoleManager;
    void Start()
    {
        //InputField = GameObject.Find("console").GetComponent<InputField>();
        ammoManager = this.gameObject.GetComponent<AmmoManagerReloaded>();
        firstPersonController = GameObject.Find("FPSController").GetComponent<FirstPersonController>();
        InputFieldGM.SetActive(false);
        typedText = "";
        healthManager = GameObject.Find("FPSController").GetComponent<HealtManager>();
        moneyManager = GameObject.Find("_scripts").GetComponent<MoneyManager>();
    }

    void Update()
    {
       

        if (Input.GetKeyDown(keycode) && !chatOpen)
        {
            chatOpen = true;
            InputField.text = "";
            if (chatOpen)
            {
                InputFieldGM.SetActive(true);
                firstPersonController.enabled = false;
                healthBar.SetActive(false);
                AmmoGUI.SetActive(false);
            }
            else
            {
                InputFieldGM.SetActive(false);
                firstPersonController.enabled = true;
            }
        }

        if (InputFieldGM.activeSelf)
        {
            InputField.Select();
            InputField.ActivateInputField();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //set InputField text to local varible
            typedText = InputField.text;
            //set inputfield text to ""
            InputField.text = "";
            InputFieldGM.SetActive(false);
            healthBar.SetActive(true);
            AmmoGUI.SetActive(true);
            chatOpen = false;
            firstPersonController.enabled = true;
            //check if any commands has been typed
            if (typedText.Contains("/give ammo"))
            {
                ammoManager.privateMaxBullets += 100;
            }
            if (typedText == "/quit")
            {
                Application.Quit();
                Debug.Log("quit");
            }
            if (typedText == "/god")
            {
                godMode = !godMode;
            }
            if (typedText == "/spawn barrel")
            {
                GameObject player;
                player = GameObject.Find("FPSController");
                Instantiate(barrel, new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z + 2), new Quaternion(0, 0, 0, 0));
            }
            if (typedText == "/reset score")
            {
                PlayerPrefs.SetInt("hszk", 0);
                PlayerPrefs.SetInt("zk", 0);
                PlayerPrefs.SetInt("money", 0);
            }
            if (typedText == "/reset settings")
            {
                PlayerPrefs.SetInt("aa", 0);
                PlayerPrefs.SetInt("refr", 0);
                PlayerPrefs.SetInt("fpsMeter", 0);
                PlayerPrefs.SetInt("sdd", 0);
                PlayerPrefs.SetInt("sq", 0);
            }
            if(typedText == "/give money"){
                moneyManager.CurrentMoney = moneyManager.CurrentMoney + 100000;
            }
            //show error if command isnt found(not working)
            // if (typedText.Contains("/quit") || typedText.Contains("/trow error") || typedText.Contains("/clear console") || 
            //typedText.Contains("/loadscene hospital") || typedText.Contains("/loadscene 01") || typedText.Contains("/test") ||typedText.Contains("")){
            // Debug.Log("found command text is: " + typedText);
            //}else{
            //CommandNotFound();  
            //Debug.LogError("command not found!");
            //}



        }
        if (godMode)
        {
            healthManager.currentHealth = 100;
        }
    }

    void CommandNotFound()
    {
        errorMes.SetActive(true);
        StartCoroutine(timerwws());

    }
    IEnumerator timerwws()
    {
        yield return new WaitForSeconds(2);
        errorMes.SetActive(false);
    }
}
