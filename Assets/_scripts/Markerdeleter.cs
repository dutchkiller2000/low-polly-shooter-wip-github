using System.Collections;
using UnityEngine;

public class Markerdeleter : MonoBehaviour
{
    public bool deleteMarker;
    public int deleteTime;
    void Start()
    {
        if (deleteMarker)
        {
            StartCoroutine(delete());
        }
    }

    IEnumerator delete()
    {
        yield return new WaitForSeconds(deleteTime);
        Destroy(this.gameObject);
    }
}
