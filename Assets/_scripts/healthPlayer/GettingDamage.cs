using System.Collections;
using UnityEngine;

public class GettingDamage : MonoBehaviour
{
    zombieDamage zombieDamage;
    int timer;
    void Start()
    {

    }

    void Update()
    {

    }
    void OnTriggerEnter(Collider coll)
    {
    }
    void OnTriggerStay(Collider coll)
    {
        timer++;
        if (coll.gameObject.tag == "zombie")
        {
            zombieDamage = coll.GetComponent<zombieDamage>();

            if (timer >= zombieDamage.hitSpeed)
            {
                timer = 0;
                this.GetComponentInParent<HealtManager>().currentHealth = this.GetComponentInParent<HealtManager>().currentHealth - Random.Range( coll.GetComponent<zombieDamage>().minDamage, coll.GetComponent<zombieDamage>().maxDamage);
            }
        }
    }
}
