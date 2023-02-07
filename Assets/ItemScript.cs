using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class ItemScript : MonoBehaviour
{
    public bool isActive = false;
    public Transform playerHand;
    public Transform itemTransform;
    public Rigidbody2D theRB;

    private void FixedUpdate()
    {
        if(isActive == true)
        {
            var itemHeld = itemTransform;
            itemHeld.transform.position = playerHand.transform.position;
            itemTransform = itemHeld;

            var _bodyType = theRB;
            _bodyType.bodyType = RigidbodyType2D.Kinematic;
            theRB = _bodyType;
        }
        if (isActive == true && Input.GetKey(KeyCode.L) == true)
        {
            isActive = false;
            var _bodyType = theRB;
            _bodyType.bodyType = RigidbodyType2D.Dynamic;
            theRB = _bodyType;
        }
    }

}
