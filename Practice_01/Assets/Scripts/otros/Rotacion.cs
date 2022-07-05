using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    public float rotSpeed;

    private void Update()
    {
        transform.Rotate(0, rotSpeed * Time.deltaTime, 0);
    }
}