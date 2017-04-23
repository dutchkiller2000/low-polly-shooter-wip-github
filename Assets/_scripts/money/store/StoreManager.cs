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
    ConsoleManager consoleManager;
    BuildingManager buildingManager;
    void Start()
    {
        simpleShooting = GameObject.Find("_scripts").GetComponent<SimpleShooting>();
        pauseManager = GameObject.Find("_scripts").GetComponent<PauseManager>();
        consoleManager = GameObject.Find("_scripts").GetComponent<ConsoleManager>();
        buildingManager = GameObject.Find("_scripts").GetComponent<BuildingManager>();

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
        if (!consoleManager.chatOpen)
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
    }
    //need to disnable player so ai wont move anymore or just disnable ai
    public void OnStoreOpen()
    {
        storeUI.SetActive(true);
        fps.enabled = false;
        simpleShooting.enabled = false;
        for (int i = 0; i < GMToDisn.Length; i++)
        {
            GMToDisn[i].SetActive(false);
        }
        StartCoroutine(canOpenAgain());
        buildingManager.enabled = false;
        Cursor.visible = true;
    }
    public void OnStoreClose()
    {
        simpleShooting.enabled = true;
        fps.enabled = true;
        storeUI.SetActive(false);
        for (int i = 0; i < GMToDisn.Length; i++)
        {
            GMToDisn[i].SetActive(true);
        }
        StartCoroutine(canOpenAgain());
        pauseManager.isPaused = false;
        buildingManager.enabled = true;
        Cursor.visible = false;
    }
    IEnumerator canOpenAgain()
    {
        yield return new WaitForSecondsRealtime(1);
        canOpenStore = true;
    }
}
