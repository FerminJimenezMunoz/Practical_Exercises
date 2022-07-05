using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioMetodo_1 : MonoBehaviour
{
    public float precio, descuento, IVA;
    private float precioDescuento, precioIVA;

    // Start is called before the first frame update
    private void Start()
    {
        precioDescuento = AplicarDescuento(precio, descuento);
        precioIVA = AplicarIVA(precio, IVA);
        Debug.Log($"Precio final con Descuento {precioDescuento} €");
        Debug.Log($"Precio final con IVA {precioIVA} €");
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public float AplicarDescuento(float a, float b)
    {
        b /= 100;
        return a - (a * b);
    }

    public float AplicarIVA(float a, float b)
    {
        b /= 100;
        return a + (a * b);
    }
}