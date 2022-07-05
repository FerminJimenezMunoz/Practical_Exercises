using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationZ : MonoBehaviour
{
    private float rotSpeed = 10;

    private void Update()
    {
        transform.Rotate(0, 0, rotSpeed * Time.deltaTime);
    }
}