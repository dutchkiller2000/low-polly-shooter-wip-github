﻿using System.Collections;
using UnityEngine;
using UnityEngine.AI;
public class EnemyAI : MonoBehaviour
{
    NavMeshAgent agent;
    public int gravity;
    public bool maglopen;

    PauseManager PauseManager;
    StoreManager storeManager;
    public GameObject player;
    void Start()
    {
        maglopen = true;
        agent = GetComponent<NavMeshAgent>();
        PauseManager = GameObject.Find("_scripts").GetComponent<PauseManager>();
        player = GameObject.Find("FPSController");
        storeManager = GameObject.Find("StoreTrigger").GetComponent<StoreManager>();
    }

    void Update()
    {
        if (!PauseManager.isPaused)
        {
            if (player.activeInHierarchy)
            {
                if (GameObject.Find("enemy") || GameObject.Find("enemy(Clone)"))
                {


                    Vector3 moveDirection = Vector3.zero;
                    moveDirection = this.transform.position;
                    moveDirection.y -= gravity * Time.deltaTime;

                    if (maglopen && !storeManager.StoreOpen)
                    {
                        agent.destination = player.GetComponent<Transform>().position;

                    }
                    else
                    {
                        agent.destination = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
                    }
                }
            }
        }
    }
    void OnTriggerStay(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
            maglopen = false;
    }
    void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
            maglopen = true;
    }
}
