using System.Collections;
using UnityEngine;
using raycastNS;

public class ItemSpawnerManager : MonoBehaviour
{
    public KeyCode keyBind;
    [SpaceAttribute]
    public GameObject itemThatNeedToSpawn;
    [HeaderAttribute("spawn location")]
    public Vector3 position;
    public Transform rotation;
    raycast raycast;
    [HeaderAttribute("GameObject that the spawned can set as parrent")]
    public GameObject parrent;
    void Start()
    {
        raycast = GameObject.Find("FirstPersonCharacter").GetComponent<raycast>();
    }

    void Update()
    {
        if (Input.GetKeyDown(keyBind))
        {
            position = raycast.hit.point;
            position.y += .5f;
            Instantiate(itemThatNeedToSpawn, position, rotation.rotation);
        }
        //FIXME:
        //sets spawned item to a child(NOT WORKING BECAUSE THE NAME ARE ALL THE SAME!)
        // if (GameObject.Find("barrelExploding(Clone)"))
        // {
        //     GameObject barrel = GameObject.Find("barrelExploding(Clone)");
        //     barrel.transform.parent = parrent.transform;
        // }
    }
}
