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

	[HideInInspector]
    public int privateBullets;
	[HideInInspector]
    public int privateMags;
	[HideInInspector]
	public bool canShoot;
    public AudioSource AudioSource;
    void Start()
    {
        privateBullets = bullets;
        privateMags = mags;
        reloadText.SetActive(false);
    }

    void Update()
    {
        bulletsText.text = privateBullets.ToString();
        magsText.text = privateMags.ToString();
        if (Input.GetKeyDown(KeyCode.R) && privateMags > 0 && privateBullets >= 0)
        {
            privateMags -= 1;
            privateBullets = bullets;
            reloadText.SetActive(false);
        }
		if(privateBullets <=0){
			canShoot = false;
		}else{
			canShoot = true;
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
