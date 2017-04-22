using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour {
    public GameObject[] inventoryItems;
    public RawImage[] rawImage;
    public int freeSlot;
    public Texture transparant;
    void Start () {
		
	}
	
	void Update () {
        CheckInvSpace();
        Removeitem();
    }

    private void Removeitem()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int _randomNumber = UnityEngine.Random.Range(0, 6);

            if(inventoryItems[_randomNumber] != null)
            {
                inventoryItems[_randomNumber] = null;
                rawImage[_randomNumber].texture = transparant;
            Debug.LogWarning("This is a placeholder code of removeing an item of your inventory that is now doing stuff now!");
            }
        }
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
