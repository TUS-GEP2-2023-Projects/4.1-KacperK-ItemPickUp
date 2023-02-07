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
    void OnDrawGizmos()
    {
        bool rayHit = Physics2D.Raycast(grabRay.position, Vector2.right, grabDistance, Items);

        if (rayHit == true && Input.GetKey(KeyCode.K) == true)
        {
            Debug.Log("ItemDetected");
            _item.isActive = true;
        }

        if (drawRay)
        {
            Gizmos.color = Color.green;

            Vector2 rayStartPosition = grabRay.position;
            Vector2 rayDirection = Vector2.right * transform.localScale.x;

            Gizmos.DrawLine(rayStartPosition, rayStartPosition + (rayDirection * grabDistance));
        }
    }

}
