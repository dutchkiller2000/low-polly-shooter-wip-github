using System.Collections;
using UnityEngine;

public class StoreManager : MonoBehaviour
{
    public KeyCode openStore;
    public GameObject storeUI;
    [HideInInspector]
    public bool StoreOpen = false;
    public GameObject[] GMToDisn;
    public bool canOpenStore = true;
    void Start()
    {

    }

    void OnTriggerStay(Collider coll)
    {
        Debug.Log("collider works");
        if (coll.gameObject.tag == "Player")
        {
            //press e to open store tab
            if (Input.GetKeyDown(openStore))
            {
                if (canOpenStore)
                {
                    StoreOpen = !StoreOpen;
                    canOpenStore = false;
                    if (StoreOpen)
                    {
                        OnStoreOpen();
                    }
                    else
                    {
                        OnStoreClose();
                    }
                    StartCoroutine(canOpenAgain());
                }
            }
        }

    }
    public void OnStoreOpen()
    {
        storeUI.SetActive(true);
        Time.timeScale = 0;
        for (int i = 0; i < GMToDisn.Length; i++)
        {
            GMToDisn[i].SetActive(false);
        }
    }
    public void OnStoreClose()
    {
        storeUI.SetActive(false);
        Time.timeScale = 1;
        for (int i = 0; i < GMToDisn.Length; i++)
        {
            GMToDisn[i].SetActive(true);
        }
    }
    IEnumerator canOpenAgain()
    {
        yield return new WaitForSecondsRealtime(1);
        canOpenStore = true;
    }
}
