using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger2D : MonoBehaviour
{
    public LayerMask Player;
    public Transform Parent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Utils.IsInLayerMask(collision.gameObject, Player))
        {
            collision.transform.SetParent(Parent);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (Utils.IsInLayerMask(collision.gameObject, Player))
        {
            collision.transform.SetParent(null);
        }
    }
}