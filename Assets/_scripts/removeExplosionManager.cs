using System.Collections;
using UnityEngine;

public class removeExplosionManager : MonoBehaviour {

	void Start () {
        StartCoroutine(remove());
    }
	IEnumerator remove(){
        yield return new WaitForSecondsRealtime(2);
        Destroy(this.gameObject);
    }
	
}
