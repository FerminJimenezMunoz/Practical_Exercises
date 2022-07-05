using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioCondi_1 : MonoBehaviour
{

    public int valor1;
    int resultado;

    // Start is called before the first frame update
    void Start()
    {
        resultado = valor1 % 2;

        if (resultado == 0)
        {
            Debug.Log("El número es Par");
        }
        else
        {
            Debug.Log("El número es Impar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
