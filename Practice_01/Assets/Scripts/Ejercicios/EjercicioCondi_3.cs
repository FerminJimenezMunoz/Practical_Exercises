using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioCondi_3 : MonoBehaviour
{

    public float valorDivisor, valorDividendo;
    float resultadoDivision;

    // Start is called before the first frame update
    void Start()
    {
        resultadoDivision = valorDividendo / valorDivisor;

        if (valorDivisor == 0)
        {
            Debug.Log("Error: No se puede dividir por 0");
        }

        else
        {
            Debug.Log("El resultado de la division es " + resultadoDivision);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
