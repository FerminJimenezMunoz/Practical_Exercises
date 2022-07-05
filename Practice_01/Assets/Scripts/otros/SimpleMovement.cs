using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float speed = 5;
    public float rotSpeed = 5;

    private void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
        transform.Rotate(0, rotSpeed * Time.deltaTime, 0);
    }
}