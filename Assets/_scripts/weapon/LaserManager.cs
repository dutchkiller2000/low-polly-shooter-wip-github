using System;
using System.Collections;
using UnityEngine;

public class LaserManager : MonoBehaviour {
    bool laserOn;
    GameObject laser;
	void Start () {
        laser = GameObject.Find("Laser");
        laserOn = true;
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.L)) laserOn = !laserOn;

        Laser();
	}
    void Laser()
    {
        if (laserOn)
        {
            laser.SetActive(true);
        }
        else
        {
            laser.SetActive(false);
        }
    }
}
