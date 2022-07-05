using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioCondi_4 : MonoBehaviour
{

    public int edad, ingresosMensuales;

    // Start is called before the first frame update
    void Start()
    {
        if(edad > 16 && ingresosMensuales >= 1000)
        {
            Debug.Log("Tienes que tributar");
        }

        else
        {
            Debug.Log("No tienes que tributar");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
