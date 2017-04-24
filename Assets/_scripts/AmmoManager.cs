using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class AmmoManager : MonoBehaviour
{
    [HeaderAttribute("starting ammo(bullets is max bullet in a clip)")]
    public int bullets;
    public int mags;
    [HeaderAttribute("Ammo UI")]
    public Text bulletsText;
    public Text magsText;
    public GameObject reloadText;
    public GameObject reloadingText;

    [HideInInspector]
    public int privateBullets;
    [HideInInspector]
    public int privateMags;
    [HideInInspector]
    public bool canShoot;
    public AudioSource AudioSource;
    [HeaderAttribute("reloadTime is in frames not seconds!")]
    public int reloadTime;
    bool reloading;
    int timer;
    BuildingManager buildingManager;

    PauseManager pauseManager;
    void Start()
    {
        privateBullets = bullets;
        privateMags = mags;
        reloadText.SetActive(false);
        reloadingText.SetActive(false);
        pauseManager = GameObject.Find("_scripts").GetComponent<PauseManager>();
        buildingManager = GameObject.Find("_scripts").GetComponent<BuildingManager>();
    }

    void Update()
    {
        Reload();
        bulletsText.text = privateBullets.ToString();
        magsText.text = privateMags.ToString();
        if (Input.GetKeyDown(KeyCode.R) && privateMags > 0 && !pauseManager.isPaused)
        {
            reloading = true;
            reloadText.SetActive(false);
            reloadingText.SetActive(true);
        }
        if (privateBullets <= 0 || reloading)
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

    public void Reload()
    {
        if (reloading)
        {
            reloadText.SetActive(false);
            canShoot = false;
            timer++;
            if (timer >= reloadTime)
            {
                timer = 0;
                privateMags -= 1;
                privateBullets = bullets;
                reloading = false;
                reloadingText.SetActive(false);
                canShoot = true;
            }
        }
    }
    public void Shoot()
    {
        if (privateBullets > 0)
        {
            privateBullets -= 1;
            AudioSource.Play();
        }
        if (privateBullets <= 0)
        {
            reloadText.SetActive(true);
        }
    }
}
