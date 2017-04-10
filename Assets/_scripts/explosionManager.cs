using System.Collections;
using UnityEngine;

public class explosionManager : MonoBehaviour
{
    public GameObject Explosion;
    [HeaderAttribute("the name of a tag that can trigger the Explosion on Collision enter")]
    public string tagName;
    [HeaderAttribute("|Note: find out if ofset needed if game is running because values change if game runs|offset if explosion got Instantiated in the GameObject and not above or something")]
    public float Yoffset;
    Vector3 offsetPos;
    void OnCollisionEnter(Collision coll)
    {

        if (coll.gameObject.tag == tagName)
        { 
            offsetPos = this.transform.position;
            offsetPos.y = offsetPos.y + Yoffset;
            Instantiate(Explosion, offsetPos, transform.rotation);
            Destroy(this.gameObject);
            Destroy(coll.gameObject);
        }
    }
}
