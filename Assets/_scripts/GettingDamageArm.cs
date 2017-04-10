using System.Collections;
using UnityEngine;

public class GettingDamageArm : MonoBehaviour
{
    GettingDamageManager gettingDamageManager;
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
                gettingDamageManager.currentHealth = gettingDamageManager.currentHealth - bulletDamageManager.arms;
            }
            if(gettingDamageManager.debug){
                Debug.Log("the player lost: " + bulletDamageManager.arms + " health so it has now: " + gettingDamageManager.currentHealth+" health!");
            }
        }
    }
}
