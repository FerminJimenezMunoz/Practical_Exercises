using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_2 : MonoBehaviour
{

    public int cuentaBancaria;
    float cuentaFinal;

    // Start is called before the first frame update
    void Start()
    {
        cuentaFinal = cuentaBancaria * 0.8f;
        Debug.Log("La cantidad final es de " + cuentaFinal + " euros");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
