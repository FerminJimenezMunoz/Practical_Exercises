using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioMetodo_3 : MonoBehaviour
{
    private int suma;
    public int num1, num2;

    // Start is called before the first frame update
    private void Start()
    {
        SumaDeEnteros(num1, num2);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void SumaDeEnteros(int numero1, int numero2)
    {
        for (int i = numero1; i <= numero2; i++)
        {
            suma += i;
        }
        Debug.Log(suma);
    }
}