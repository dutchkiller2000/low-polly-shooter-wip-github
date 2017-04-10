using System.Collections;
using UnityEngine;

public class cloudSpawner : MonoBehaviour
{
    public int spawnrate;
    int timer;
	public GameObject[] clouds;
    void Start()
    {

    }

    void Update()
    {
        timer++;

        if (timer >= spawnrate)
        {
			timer = 0;
			//spawm cloud
			//pick random cloud first
			Vector3 pos;
			pos.x = Random.value;
			pos.y = Random.Range(280,600);
			pos.z = Random.value;

			Quaternion rot = new Quaternion(0,0,0,0);
			Instantiate(clouds[Random.Range(0,clouds.Length)],pos,rot);
        }
       
    }
}
