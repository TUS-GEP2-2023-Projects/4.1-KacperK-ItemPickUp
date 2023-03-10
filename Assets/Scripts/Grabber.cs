using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabber : MonoBehaviour
{
    public float grabDistance = 1f;
    public bool drawRay = true;
    public Transform grabRay;
    public LayerMask Items;
    public ItemScript _item;
    public Vector2 _rayDirection;
    public CharacterController _characterController;
    void OnDrawGizmos()
    {
        bool rayHit = Physics2D.Raycast(grabRay.position, _rayDirection, grabDistance, Items);

        if (rayHit == true && Input.GetKey(KeyCode.K) == true)
        {
            Debug.Log("ItemDetected");
            _item.isActive = true;
        }

        if (drawRay)
        {
            Gizmos.color = Color.green;

            Vector2 rayStartPosition = grabRay.position;
            Vector2 rayDirection = _rayDirection * transform.localScale.x;

            Gizmos.DrawLine(rayStartPosition, rayStartPosition + (_rayDirection * grabDistance));
        }
    }
    public void Update()
    {
        if(_characterController.facingRight == true)
        {
            _rayDirection = Vector2.right;
        }
        else
        {
            _rayDirection = Vector2.left;
        }
    }
}
