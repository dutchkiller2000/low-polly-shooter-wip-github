using System.Collections;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    [HeaderAttribute("keybind to enable/disnable pause menu")]
    public KeyCode PauseKeyBind;
    [HeaderAttribute("player character to disnable")]
    public GameObject character;
    [HeaderAttribute("GameObject of pauseMenu to en/disnable|| and other gameObjects")]
    public GameObject pauseMenu;
    public GameObject ammoUI;
    public GameObject healthSlider;
	SimpleShooting simpleShootingsc;
    ItemSpawnerManager itemSpawnerManagersc;
    ConsoleManager consoleManager;


    public bool isPaused;

    void Start()
    {
		simpleShootingsc = GameObject.Find("_scripts").GetComponent<SimpleShooting>(); // error
		itemSpawnerManagersc = GameObject.Find("_scripts").GetComponent<ItemSpawnerManager> (); // error
        consoleManager = this.gameObject.GetComponent<ConsoleManager>();
    }
    void Update(){
        if (Input.GetKeyDown(PauseKeyBind))
        {
            isPaused = !isPaused;
            pause();
        }
    }
    void pause()
    {
        
        if (isPaused)
        {
            //disnable player character
            character.SetActive(false);
            //enable gm of paus menu
            pauseMenu.SetActive(true);
            //time scale
            Time.timeScale = 0;
            //show cursor
            Cursor.visible = true;
            itemSpawnerManagersc.enabled = false;
            simpleShootingsc.enabled = false;
            consoleManager.enabled = false; 
            consoleManager.InputFieldGM.SetActive(false);
            ammoUI.SetActive(false);
            healthSlider.SetActive(false);
        }
        else
        {
            character.SetActive(true);
            pauseMenu.SetActive(false);
            Time.timeScale = 1;
            Cursor.visible = false;
			itemSpawnerManagersc.enabled = true;
			simpleShootingsc.enabled = true;
            consoleManager.enabled = true;  
            ammoUI.SetActive(true);
            healthSlider.SetActive(true)
;        }
    }
}