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
    void Start()
    {
        privateBullets = bullets;
        privateMags = mags;
        reloadText.SetActive(false);
        reloadingText.SetActive(false);
    }

    void Update()
    {
        Reload();
        bulletsText.text = privateBullets.ToString();
        magsText.text = privateMags.ToString();
        if (Input.GetKeyDown(KeyCode.R) && privateMags > 0 && privateBullets >= 0)
        {
            reloading = true;
            reloadText.SetActive(false);
            reloadingText.SetActive(true);
        }
        if (privateBullets <= 0)
        {
            canShoot = false;
        }
        else
        {
            canShoot = true;
        }
    }

    public void Reload()
    {
        if (reloading)
        {

            timer++;
            if (timer >= reloadTime)
            {
                timer = 0;
                privateMags -= 1;
                privateBullets = bullets;
                reloading = false;
                reloadingText.SetActive(false);
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
