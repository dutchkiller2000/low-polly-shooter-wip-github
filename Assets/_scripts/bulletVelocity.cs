using System.Collections;
using UnityEngine;

public class bulletVelocity : MonoBehaviour
{
    SimpleShooting simpleShooting;
    public int velocity;
    void Start()
    {
        simpleShooting = GameObject.Find("_scripts").GetComponent<SimpleShooting>();

        this.GetComponent<Rigidbody>().velocity = transform.forward * velocity;
        if (!simpleShooting.debug)
        {
            StartCoroutine(destroy());
        }
    }

    IEnumerator destroy()
    {
        yield return new WaitForSeconds(4);
        Destroy(this.gameObject);
    }
}
