﻿using System.Collections;
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
    StoreManager storeManager;
    BuildingManager buildingManager;


    public bool isPaused;

    void Start()
    {
        simpleShootingsc = GameObject.Find("_scripts").GetComponent<SimpleShooting>();
        itemSpawnerManagersc = GameObject.Find("_scripts").GetComponent<ItemSpawnerManager>();
        consoleManager = this.gameObject.GetComponent<ConsoleManager>();
        Cursor.visible = false;
        storeManager = GameObject.Find("StoreTrigger").GetComponent<StoreManager>(); 
        isPaused = false;
        Time.timeScale = 1;
        buildingManager = GetComponent<BuildingManager>();
    }
    void Update()
    {
        if (Input.GetKeyDown(PauseKeyBind))
        {
            isPaused = !isPaused;
            pause();
        }
    }
    void pause()
    {

        if (isPaused && !storeManager.StoreOpen)
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
            buildingManager.enabled = false;
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
            healthSlider.SetActive(true);
            buildingManager.enabled = true;
        }
    }
}