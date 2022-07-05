using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioBucle_7 : MonoBehaviour
{
    public int dividendo;
    private int divisor;

    // Start is called before the first frame update
    private void Start()
    {
        int divisor = dividendo, i = divisor;

        do
        {
            if (dividendo % i == 0)
            {
                Debug.Log(i);
            }
            i--;
        } while (i > 0);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}