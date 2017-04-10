using System.Collections;
using UnityEngine;
using UnityEngine.AI;
public class GettingDamagelegs : MonoBehaviour
{
    GettingDamageManager gettingDamageManager;
    int counter;
    [HeaderAttribute("how many times the zombie got hit to reduce speed")]
    public int timesReduceSpeed;
    [HeaderAttribute("the reducement of the speed in %!!!")]
    public int speedIfDamaged;
    int procent;
    void Start()
    {
        gettingDamageManager = GetComponentInParent<GettingDamageManager>();
    }

    void OnCollisionEnter(Collision coll)
    {
        BulletDamageManager bulletDamageManager = coll.gameObject.GetComponent<BulletDamageManager>();

        //body part damge part
        if (coll.gameObject.tag == "bullet")
        {
            if (gettingDamageManager.currentHealth <= 0)
            {
            }
            else
            {
                gettingDamageManager.currentHealth = gettingDamageManager.currentHealth - bulletDamageManager.legs;
                ChangeWalkSpeed();
            }
            if (gettingDamageManager.debug)
            {
                Debug.Log("the player lost: " + bulletDamageManager.legs + " health so it has now: " + gettingDamageManager.currentHealth + " health!");
            }
        }
    }
    void ChangeWalkSpeed()
    {
        procent = 100 - speedIfDamaged;
        counter = counter + 1;
        if (counter >= timesReduceSpeed)
        {
            GetComponentInParent<NavMeshAgent>().speed = GetComponentInParent<NavMeshAgent>().speed / 100 * procent;
        }
    }
}
