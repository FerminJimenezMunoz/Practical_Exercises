using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageMaker2D : MonoBehaviour
{
    public LayerMask PlayerMask;
    public int DamageAmount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Utils.IsInLayerMask(collision.gameObject, PlayerMask))
        {
            PlayerHealth2D health2D = collision.GetComponent<PlayerHealth2D>();
            if (health2D != null)
            {
                Debug.Log("Enter");
                health2D.TakeDamage(DamageAmount);
            }
        }
    }
}