using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioBucle_5 : MonoBehaviour
{
    public int num;
    private bool esPrimo = true;

    // Start is called before the first frame update
    private void Start()
    {
        for (int i = num - 1; i > 1; i--)
        {
            if (num % i == 0)
            {
                Debug.Log("El número no es primo");
                esPrimo = false;
                break;
            }
        }
        if (esPrimo == true)
        {
            Debug.Log("El número es primo");
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}