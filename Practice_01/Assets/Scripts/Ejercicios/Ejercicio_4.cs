using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_4 : MonoBehaviour
{

    public float precioMedicamento;
    float precioFinal, precioDescontado;
    
    // Start is called before the first frame update
    void Start()
    {
        precioFinal = precioMedicamento * 0.9F;
        precioDescontado = precioMedicamento - precioFinal;
        Debug.Log("El precio final del medicamento es de " + precioFinal + "€");
        Debug.Log("Se ha descontado " + precioDescontado+" €");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
