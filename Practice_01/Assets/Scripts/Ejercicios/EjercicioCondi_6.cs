using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioCondi_6 : MonoBehaviour
{

    public int año;
    
    // Start is called before the first frame update
    void Start()
    {
        if ((año % 4 == 0 && año % 100 != 0) || año % 400 == 0)
        {
            Debug.Log("Es año Bisiesto");
        }

        else
        {
            Debug.Log("No es año Bisiesto");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
