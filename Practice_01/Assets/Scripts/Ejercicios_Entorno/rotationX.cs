using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationX : MonoBehaviour
{
    private float rotSpeed = 10;

    private void Update()
    {
        transform.Rotate(rotSpeed * Time.deltaTime, 0, 0);
    }
}