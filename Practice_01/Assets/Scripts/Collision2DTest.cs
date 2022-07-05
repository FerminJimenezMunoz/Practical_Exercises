using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision2DTest : MonoBehaviour
{
    public LayerMask playerMask;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Utils.IsInLayerMask(collision.gameObject, playerMask))
        {
            Debug.Log($"El player ha entrado en mi trigger");
        }
    }
}