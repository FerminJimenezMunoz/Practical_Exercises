using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_5 : MonoBehaviour
{

    public float resistencia1, resistencia2;
    float resistenciaEquivalente;
    
    // Start is called before the first frame update
    void Start()
    {

        resistenciaEquivalente = (resistencia1 * resistencia2) / (resistencia1 + resistencia2);
        Debug.Log("La resisrencia equivalent en paralelo es de " + resistenciaEquivalente + " ohms");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
