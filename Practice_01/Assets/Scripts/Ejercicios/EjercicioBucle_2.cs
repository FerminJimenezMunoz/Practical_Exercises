using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioBucle_2 : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 1; i < 501; i++)
        {
            int operacion = i % 2;
            if (operacion == 0)
            {
                Debug.Log(i);
            }
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}