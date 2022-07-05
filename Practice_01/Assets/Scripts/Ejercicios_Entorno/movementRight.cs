using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementRight : MonoBehaviour
{
    private float speed = 10;

    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;
    }
}