using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioMetodo_4 : MonoBehaviour
{
    public float catet1, catet2;
    private float resultado;

    // Start is called before the first frame update
    private void Start()
    {
        resultado = CalcularHipotenusa(catet1, catet2);
        Debug.Log(resultado);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public float CalcularHipotenusa(float cateto1, float cateto2)
    {
        return Mathf.Sqrt(Mathf.Pow(cateto1, 2) + Mathf.Pow(cateto2, 2));
    }
}