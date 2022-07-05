using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioArray_3 : MonoBehaviour
{
    public int[] array;
    public int numRangoMin, numRangoMax;

    // Start is called before the first frame update
    private void Start()
    {
        MostrarArray(array, numRangoMin, numRangoMax);
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
            Debug.Log($"En la posicion {i} tiene el valor de {arrayEnteros[i]}");
        }
    }
}