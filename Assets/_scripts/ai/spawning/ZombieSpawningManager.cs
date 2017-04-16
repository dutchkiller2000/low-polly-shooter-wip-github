using System.Collections;
using UnityEngine;

public class ZombieSpawningManager : MonoBehaviour
{
    public float spawnRateInSeconds;
    public GameObject[] spawnPoints;
    public GameObject[] zombies;
    public StoreManager storeManager;
    void Start()
    {
        StartCoroutine(Spawning());
        storeManager = GameObject.Find("StoreTrigger").GetComponent<StoreManager>();
    }

    void Update()
    {

    }
    IEnumerator Spawning()
    {

        yield return new WaitForSeconds(spawnRateInSeconds);
        if (storeManager.StoreOpen == false)
        {
            Instantiate(zombies[Random.Range(0, zombies.Length)], spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position, spawnPoints[Random.Range(0, spawnPoints.Length)].transform.rotation);
            StartCoroutine(Spawning());
        }
    }


}
