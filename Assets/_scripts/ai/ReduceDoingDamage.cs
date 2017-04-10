using System.Collections;
using UnityEngine;

public class ReduceDoingDamage : MonoBehaviour
{
    int procent;
    int counter;
    public int timesReduceSpeed;
    [HeaderAttribute("the reducement of the damage in %!!!")]
    public int damageIfShot;
    void Start()
    {

    }

    void Update()
    {

    }
    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "bullet")
        {
            Debug.Log("damage reduced");

            procent = 100 - damageIfShot;
            counter = counter + 1;
            if (counter >= timesReduceSpeed)
            {
                GetComponentInChildren<zombieDamage>().damage = GetComponentInChildren<zombieDamage>().damage / 100 * procent;
				//ERROR: cant find component because its cearching in child but this gm is already a child so it doent gave child
            }
        }
    }
}
