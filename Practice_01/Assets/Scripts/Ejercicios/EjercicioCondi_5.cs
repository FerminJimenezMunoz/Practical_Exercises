using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioCondi_5 : MonoBehaviour
{

    public int valor1, valor2;
    
    // Start is called before the first frame update
    void Start()
    {
        if (valor1 == valor2)
        {
            Debug.Log("Los numeros son iguales");
        }

        else if (valor1 > valor2)
        {
            Debug.Log("El numero mayor es el Valor 1");
        }

        else
        {
            Debug.Log("El numero mayor es el Valor 2");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
