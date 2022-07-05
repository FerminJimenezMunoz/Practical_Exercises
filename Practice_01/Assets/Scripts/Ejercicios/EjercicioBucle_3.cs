using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioBucle_3 : MonoBehaviour
{
    public int max, min;

    // Start is called before the first frame update
    private void Start()
    {
        if (max > min)
        {
            for (int i = min; i <= max; i++)
            {
                int operacion = i % 2;
                if (operacion == 0)
                {
                    Debug.Log(i);
                }
            }
        }
        else
        {
            Debug.Log("Error: El número maximo no puede ser inferior al minimo");
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}