using System.Collections;
using UnityEngine;

public class BulletDamageManager : MonoBehaviour
{
//public float Damage;
    [HeaderAttribute("extra bodyparts, dont know i should do this because it cant does multible colliders so maybe lose body part")]
    public float head;
    public float arms;
    public float body;
    public float legs;

    SimpleShooting simpleShooting;
    [HeaderAttribute("enables a marker on bullet inpakt")]
    public bool debugMarker;
	public GameObject marker;
    void Start()
    {
        simpleShooting = GameObject.Find("_scripts").GetComponent<SimpleShooting>();
    }
    void OnCollisionEnter(Collision coll)
    {
        
        if (debugMarker)
        {
			ContactPoint contact = coll.contacts[0];
			Vector3 pos = contact.point;
            Instantiate(marker,pos,new Quaternion(0,0,0,0));
        
        }
         if (!simpleShooting.debug)
         {
             Destroy(this.transform.gameObject);
         }
    }
}
