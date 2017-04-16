using System.Collections;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class StoreManager : MonoBehaviour
{
    public KeyCode openStore;
    public GameObject storeUI;
    [HideInInspector]
    public bool StoreOpen = false;
    public GameObject[] GMToDisn;
    public FirstPersonController fps;
    SimpleShooting simpleShooting;
    public bool canOpenStore = true;
    PauseManager pauseManager;
    void Start()
    {
        simpleShooting = GameObject.Find("_scripts").GetComponent<SimpleShooting>();
        pauseManager = GameObject.Find("_scripts").GetComponent<PauseManager>();
    }

    void Update()
    {
        if (StoreOpen)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                StoreOpen = false;
                OnStoreClose();
            }
        }
    }

    void OnTriggerStay(Collider coll)
    {
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
                    
                }
            }
        }

    }
    //need to disnable player so ai wont move anymore or just disnable ai
    public void OnStoreOpen()
    {
        storeUI.SetActive(true);
        fps.enabled = false;
        Cursor.visible = true;
        simpleShooting.enabled = false;
        for (int i = 0; i < GMToDisn.Length; i++)
        {
            GMToDisn[i].SetActive(false);
        }
        StartCoroutine(canOpenAgain());
    }
    public void OnStoreClose()
    {
        simpleShooting.enabled = true;
        fps.enabled = true;
        storeUI.SetActive(false);
        Cursor.visible = false;
        for (int i = 0; i < GMToDisn.Length; i++)
        {
            GMToDisn[i].SetActive(true);
        }
        StartCoroutine(canOpenAgain());
        pauseManager.isPaused = false;
        
    }
    IEnumerator canOpenAgain()
    {
        yield return new WaitForSecondsRealtime(1);
        canOpenStore = true;
    }
}
