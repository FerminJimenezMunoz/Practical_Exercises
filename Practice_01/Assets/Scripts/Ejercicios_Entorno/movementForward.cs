using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementForward : MonoBehaviour
{
    private float speed = 10;

    private void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
    }
}