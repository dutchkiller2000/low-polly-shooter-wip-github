using System.Collections;
using UnityEngine;

public class ZombieSpawningManager : MonoBehaviour
{
    public float spawnRateInSeconds;
    public GameObject[] spawnPoints;
    public GameObject[] zombies;
    void Start()
    {
        StartCoroutine(Spawning());
    }

    void Update()
    {

    }
    IEnumerator Spawning()
    {
        yield return new WaitForSeconds(spawnRateInSeconds);
        Instantiate(zombies[Random.Range(0, zombies.Length)], spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position,spawnPoints[Random.Range(0, spawnPoints.Length)].transform.rotation);
        StartCoroutine(Spawning());
    }


}
