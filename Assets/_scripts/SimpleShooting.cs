using System.Collections;
using UnityEngine;

public class SimpleShooting : MonoBehaviour
{
    public bool automatic;
    public float fireRate;
    public GameObject bullet;
    public GameObject spawnPos;
    [HeaderAttribute("enable/disnable lag test(disnable bullet despawner and enabled counter)")]
    public bool debug;
    //fire rate stuff
    float timer;
    AmmoManager ammoManager;
    void Start()
    {
        ammoManager = this.gameObject.GetComponent<AmmoManager>();
    }

    void FixedUpdate()
    {
        if (automatic)
        {
            if (Input.GetMouseButton(0)&& ammoManager.canShoot)
            {
                timer++;
                if (timer >= fireRate)
                {
                    timer = 0;
                    Instantiate(bullet, spawnPos.transform.position, spawnPos.transform.rotation);
                    ammoManager.Shoot();
                    if (debug)
                    {
                        Debug.Log("bullet counter");
                    }
                }
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0)&& ammoManager.canShoot)
            {
                Instantiate(bullet, spawnPos.transform.position, spawnPos.transform.rotation);
                ammoManager.Shoot();
                if (debug)
                {
                    Debug.Log("bullet counter");
                }
            }
        }

    }
}
