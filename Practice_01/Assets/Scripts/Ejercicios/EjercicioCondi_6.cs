using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioCondi_6 : MonoBehaviour
{

    public int a�o;
    
    // Start is called before the first frame update
    void Start()
    {
        if ((a�o % 4 == 0 && a�o % 100 != 0) || a�o % 400 == 0)
        {
            Debug.Log("Es a�o Bisiesto");
        }

        else
        {
            Debug.Log("No es a�o Bisiesto");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
