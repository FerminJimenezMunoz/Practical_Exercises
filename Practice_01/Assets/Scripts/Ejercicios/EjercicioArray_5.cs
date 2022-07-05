using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioArray_5 : MonoBehaviour
{
    public int[] array;
    public int numRangoMin, numRangoMax;

    // Start is called before the first frame update
    private void Start()
    {
        MostrarArray(array, numRangoMin, numRangoMax);
        MostrarValorGrandeArray(array);
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

    public void MostrarValorGrandeArray(int[] arrayEnteros)
    {
        int i, valorGrande, posicionGrande;
        valorGrande = arrayEnteros[0];
        posicionGrande = arrayEnteros[0];
        for (i = 0; i < arrayEnteros.Length; i++)
        {
            if (valorGrande < arrayEnteros[i])
            {
                posicionGrande = i;
                valorGrande = arrayEnteros[i];
            }
        }
        Debug.Log($"En la posicion {posicionGrande} tiene el valor mas grande de {valorGrande}");
    }
}