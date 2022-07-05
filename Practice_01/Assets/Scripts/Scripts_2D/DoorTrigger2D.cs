using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger2D : MonoBehaviour
{
    public LayerMask Playermask;
    public Door2D door;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Utils.IsInLayerMask(collision.gameObject, Playermask))
        {
            door.OpenDoor();
        }
    }
}