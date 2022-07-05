using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioArray_2 : MonoBehaviour
{
    private int num;
    public int[] array;

    // Start is called before the first frame update
    private void Start()
    {
        MostrarArray(array);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void MostrarArray(int[] arrayEnteros)
    {
        int numeroEntero = 0;
        for (int i = 0; i < arrayEnteros.Length; i++)
        {
            numeroEntero += arrayEnteros[i];
        }
        Debug.Log($"La suma total del array es {numeroEntero}");
    }
}