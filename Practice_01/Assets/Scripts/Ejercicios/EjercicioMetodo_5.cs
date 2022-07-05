using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioMetodo_5 : MonoBehaviour
{
    public float radio1;
    private float area, perimetro, volumen;

    // Start is called before the first frame update
    private void Start()
    {
        area = CalcularAreaCirculo(radio1);
        perimetro = CalcularPerimetroCirculo(radio1);
        volumen = CalcularVolumenCirculo(radio1);
        Debug.Log($"El area es {area}");
        Debug.Log($"El perimetro es {perimetro}");
        Debug.Log($"El volumen es {volumen}");
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public float CalcularAreaCirculo(float radio)
    {
        return Mathf.PI * Mathf.Pow(radio, 2);
    }

    public float CalcularPerimetroCirculo(float radio)
    {
        return 2 * Mathf.PI * radio;
    }

    public float CalcularVolumenCirculo(float radio)
    {
        return (4 * Mathf.PI * Mathf.Pow(radio, 3)) / 3;
    }
}