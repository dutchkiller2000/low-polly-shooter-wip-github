using System;
using System.Collections;
using UnityEngine;

public class BuildingManager : MonoBehaviour {
    InventoryManager inventoyManager;
    GameObject buildingGM;
    public bool isbuilding;
    RaycastHit hit;
    Ray ray;
    public float rayCastRange;
    void Start() {
        inventoyManager = GetComponent<InventoryManager>();
    }

    void Update() {
        GettingInvItem();
        building();
        RotateItem();
    }


    private void building()
    {
        if (isbuilding)
        {

            var ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
            if (Physics.Raycast(ray, out hit, rayCastRange))
            {
                GameObject.Find(buildingGM.name + "(Clone)").transform.position = hit.point;
                Debug.DrawLine(GameObject.Find("FirstPersonCharacter").transform.position, hit.point, Color.green);
            }


            if (Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))    
            {
                    isbuilding = false;
                    GameObject.Find(buildingGM.name + "(Clone)").layer = 0;
                    GameObject.Find(buildingGM.name + "(Clone)").name = buildingGM.name;
                    buildingGM = null;
            }
        }
    }
        private void GettingInvItem()
        {
        if (!isbuilding)
        {

            //if() check if pause and check if in store = false too
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                if (inventoyManager.inventoryItems[0] != null)
                {

                    Instantiate(inventoyManager.inventoryItems[0], new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
                    buildingGM = inventoyManager.inventoryItems[0];
                    inventoyManager.inventoryItems[0] = null;
                    inventoyManager.rawImage[0].texture = inventoyManager.transparant;
                    isbuilding = true;
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                if (inventoyManager.inventoryItems[1] != null)
                {
                    Instantiate(inventoyManager.inventoryItems[1], new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
                    buildingGM = inventoyManager.inventoryItems[1];
                    inventoyManager.inventoryItems[1] = null;
                    inventoyManager.rawImage[1].texture = inventoyManager.transparant;
                    isbuilding = true;
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                if (inventoyManager.inventoryItems[2] != null)
                {
                    Instantiate(inventoyManager.inventoryItems[2], new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
                    buildingGM = inventoyManager.inventoryItems[2];
                    inventoyManager.inventoryItems[2] = null;
                    inventoyManager.rawImage[2].texture = inventoyManager.transparant;
                    isbuilding = true;
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                if (inventoyManager.inventoryItems[3] != null)
                {
                    Instantiate(inventoyManager.inventoryItems[3], new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
                    buildingGM = inventoyManager.inventoryItems[3];
                    inventoyManager.inventoryItems[3] = null;
                    inventoyManager.rawImage[3].texture = inventoyManager.transparant;
                    isbuilding = true;
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                if (inventoyManager.inventoryItems[4] != null)
                {
                    Instantiate(inventoyManager.inventoryItems[4], new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
                    buildingGM = inventoyManager.inventoryItems[4];
                    inventoyManager.inventoryItems[4] = null;
                    inventoyManager.rawImage[4].texture = inventoyManager.transparant;
                    isbuilding = true;
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                if (inventoyManager.inventoryItems[5] != null)
                {
                    Instantiate(inventoyManager.inventoryItems[5], new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
                    buildingGM = inventoyManager.inventoryItems[5];
                    inventoyManager.inventoryItems[5] = null;
                    inventoyManager.rawImage[5].texture = inventoyManager.transparant;
                    isbuilding = true;
                }
            }
        }
    }  
    void RotateItem()
    {
        if (isbuilding)
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0 || Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                GameObject gm = GameObject.Find(buildingGM.name + "(Clone)");
                Debug.Log(gm.transform.rotation.y + (Input.GetAxis("Mouse ScrollWheel") * 100));
                Vector3 pos = new Vector3(gm.transform.eulerAngles.x, gm.transform.eulerAngles.y , gm.transform.eulerAngles.z);
                pos = new Vector3(pos.x, pos.y+ (Input.GetAxis("Mouse ScrollWheel") *100), pos.z);
                gm.transform.eulerAngles = pos;
            }
            //else
            //{
            //    GameObject gm = GameObject.Find(buildingGM.name + "(Clone)");
            //    Debug.Log(gm.transform.rotation.y + (Input.GetAxis("Mouse ScrollWheel") * 100));
            //    Vector3 pos = new Vector3(gm.transform.eulerAngles.x, gm.transform.eulerAngles.y, gm.transform.eulerAngles.z);
            //    pos = new Vector3(pos.x, pos.y + (Input.GetAxis("Mouse ScrollWheel") * 100), pos.z);
            //    gm.transform.eulerAngles = pos;
            //}
        }
    }
}
