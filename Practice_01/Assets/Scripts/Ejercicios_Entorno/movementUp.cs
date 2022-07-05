using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementUp : MonoBehaviour
{
    private float speed = 10;

    private void Update()
    {
        transform.position += transform.up * Time.deltaTime * speed;
    }
}