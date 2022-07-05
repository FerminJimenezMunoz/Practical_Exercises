using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampolin2D : MonoBehaviour
{
    public Transform ForceDirection;
    public float ForceAmount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D rigidbody2D = collision.gameObject.GetComponent<Rigidbody2D>();
        print(collision.name);
        if (rigidbody2D != null)
        {
            rigidbody2D.AddForce(ForceDirection.right * ForceAmount, ForceMode2D.Impulse);
        }
    }
}