using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class AmmoManagerReloaded : MonoBehaviour {
    public Text bulletText;
    public Text totalBullets;
    public GameObject reloadText;
    public int BulletInMag;
    public int maxBullets;
    int privateBulletInMag;
    [HideInInspector]
    public int privateMaxBullets;
    public AudioSource AudioSource;
    private bool reloading;
    public bool canShoot;
    private int timer;

    public int reloadTime;
    public GameObject reloadingText;
    BuildingManager buildingManager;

    PauseManager pauseManager;

    void Start () {
        privateBulletInMag = 0;
        privateMaxBullets = maxBullets;
        pauseManager = GameObject.Find("_scripts").GetComponent<PauseManager>();
        buildingManager = GameObject.Find("_scripts").GetComponent<BuildingManager>();
        reloading = true;
    }

   public void Shoot() {
        if (privateBulletInMag > 0)
        {
            privateBulletInMag -= 1;
            AudioSource.Play();
        }
        if (privateBulletInMag <= 0)
        {
            reloadText.SetActive(true);
        }
    }
    void Reload()
    {
        if (reloading)
        {
            reloadText.SetActive(false);
            canShoot = false;
            timer++;
            if (timer >= reloadTime)
            {
                timer = 0;
                if(privateMaxBullets >= BulletInMag)
                {
                    privateMaxBullets = privateMaxBullets + privateBulletInMag;
                    privateBulletInMag = 0;
                    privateMaxBullets = privateMaxBullets - BulletInMag;
                    privateBulletInMag = BulletInMag;
                   
                }
                else
                {
                    Debug.Log("player has less bullets then that fit in the mag");
                    privateMaxBullets = privateMaxBullets + privateBulletInMag;
                    privateBulletInMag = 0;
                    privateBulletInMag = privateMaxBullets;
                    privateMaxBullets = privateMaxBullets - privateBulletInMag;
                }
                reloading = false;

                reloadingText.SetActive(false);
                canShoot = true;
            }
        }
    }
    private void Update()
    {
        Reload();
        bulletText.text = privateBulletInMag.ToString();
        totalBullets.text = privateMaxBullets.ToString();
        if (Input.GetKeyDown(KeyCode.R) && privateMaxBullets > 0 && !pauseManager.isPaused)
        {
            reloading = true;
            reloadText.SetActive(false);
            reloadingText.SetActive(true);
        }
        if (privateBulletInMag <= 0 || reloading)
        {
            canShoot = false;
        }
        else
        {
            canShoot = true;
        }
        if (Input.GetMouseButtonDown(0))
        {

            if (buildingManager.isbuilding)
            {
                canShoot = false;
            }
            else
            {
                canShoot = true;
            }
        }
    }
}
