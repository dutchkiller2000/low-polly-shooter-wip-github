using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour {
    public GameObject[] inventoryItems;
    public RawImage[] rawImage;
    public int freeSlot;
    void Start () {
		
	}
	
	void Update () {
        CheckInvSpace();
    }
    void CheckInvSpace()
    {

        if(inventoryItems[0] == null)
        {
            freeSlot = 0;
        }
        else 
        {
            if(inventoryItems[1] == null)
            {
                freeSlot = 1;
            }
            else
            {
                if (inventoryItems[2] == null)
                {
                    freeSlot = 2;
                }
                else
                {
                    if(inventoryItems[3] == null)
                    {
                        freeSlot = 3;
                    }
                    else
                    {
                        if (inventoryItems[4] == null)
                        {
                            freeSlot = 4;
                        }
                        else
                        {
                            if (inventoryItems[5] == null)
                            {
                                freeSlot = 5;
                            }
                        }
                    }
                }
            }
        }
    }
}
