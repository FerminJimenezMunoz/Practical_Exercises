using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioCondi_2 : MonoBehaviour
{

    public int valor1;

    // Start is called before the first frame update
    void Start()
    {

        if(valor1>100)
        {

            Debug.Log("El valor 1 es mayor que 100");

        }

        else
        {

            Debug.Log("El valor 1 es menor que 100");

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
