using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioBucle_6 : MonoBehaviour
{
    public int min, max;
    private int sumaImpar;

    // Start is called before the first frame update
    private void Start()
    {
        int i = min;
        while (i <= max)
        {
            if (i % 2 != 0)
            {
                sumaImpar += i;
                Debug.Log(i);
            }
            i++;
        }
        Debug.Log($"Suma total {sumaImpar}");
    }

    // Update is called once per frame
    private void Update()
    {
    }
}