using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioBucle_4 : MonoBehaviour
{
    public int num;
    private int resultado = 1;

    // Start is called before the first frame update
    private void Start()
    {
        for (int i = num; i > 0; i--)
        {
            resultado *= i;
        }
        Debug.Log(resultado);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}