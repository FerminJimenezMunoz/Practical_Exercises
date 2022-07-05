using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement2D : MonoBehaviour
{
    public float Speed;

    // Update is called once per frame
    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * Speed;
    }
}