using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_1 : MonoBehaviour
{
    public int numero1;
    public int numero2;
    public int numero3;
    float resultado;

    // Start is called before the first frame update
    void Start()
    {
        resultado = (float) (numero1 + numero2 + numero3) / 3;
        Debug.Log(resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}