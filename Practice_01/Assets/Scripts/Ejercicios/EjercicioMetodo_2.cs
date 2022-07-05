using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioMetodo_2 : MonoBehaviour
{
    public int num;

    // Start is called before the first frame update
    private void Start()
    {
        MostrarNumDescendentes(num);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void MostrarNumDescendentes(int numero)

    {
        for (int i = numero; i > 0; i--)
        {
            Debug.Log(i);
        }
    }
}