using System.Collections;
using UnityEngine;

public class doingDamage : MonoBehaviour
{

    public int damage;
    public int hitSpeed;
    int timer;
	void Update(){
	}
    void OnTriggerStay(Collider coll)
    {
        Debug.Log(coll.gameObject.tag);
        timer++;
        if (timer >= hitSpeed)
        {
            timer = 0;
            Debug.Log("timer works");

            if (coll.transform.parent.tag == "Player")
            {
                Debug.Log("time + it finds the player");

                coll.transform.parent.GetComponentInParent<HealtManager>().currentHealth = coll.transform.parent.GetComponent<HealtManager>().currentHealth - damage;
            }
        }

    }
}