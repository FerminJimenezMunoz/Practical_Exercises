using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioArray_1 : MonoBehaviour
{
    public int num;
    public int[] array;

    // Start is called before the first frame update
    private void Start()
    {
        MostrarArray(array, num);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void MostrarArray(int[] arrayEnteros, int num)
    {
        for (int i = 0; i < arrayEnteros.Length; i++)
        {
            arrayEnteros[i] = num;
            Debug.Log($"En la posicion {i} tiene el valor de {arrayEnteros[i]}");
        }
    }
}