using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    public bool isActive = false;
    public Transform playerHand;

    private void Update()
    {
        if(isActive == true)
        {
            Debug.Log("ItemPickedUp");
        }
    }

}
