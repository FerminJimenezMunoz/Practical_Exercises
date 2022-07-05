using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioArray_6 : MonoBehaviour
{
    public int[] array;
    public int numRangoMin, numRangoMax, num;

    // Start is called before the first frame update
    private void Start()
    {
        MostrarArray(array, numRangoMin, numRangoMax);
        MostrarPosicionValor(array, num);

        if (MostrarPosicionValor(array, num) == true)
        {
            Debug.Log($"Esta");
        }
        else
        {
            Debug.Log($"No Esta");
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void MostrarArray(int[] arrayEnteros, int num1, int num2)
    {
        for (int i = 0; i < arrayEnteros.Length; i++)
        {
            arrayEnteros[i] = Random.Range(num1, num2);
        }
    }

    public bool MostrarPosicionValor(int[] arrayEnteros, int numero)
    {
        for (int i = 0; i < arrayEnteros.Length; i++)
        {
            if (numero == arrayEnteros[i])
            {
                return true;
            }
        }
        return false;
    }
}