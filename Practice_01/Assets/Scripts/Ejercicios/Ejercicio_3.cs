using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_3 : MonoBehaviour
{

    public int lado1, lado2;
    float perimetro;
    float area;
    
    // Start is called before the first frame update
    void Start()
    {
        perimetro = (lado1 * 2) + (lado2 * 2);
        area = lado1 * lado2;
        Debug.Log("El perimetro total es de " + perimetro + " y el área total es de " + area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
