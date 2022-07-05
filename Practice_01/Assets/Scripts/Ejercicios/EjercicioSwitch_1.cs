using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioSwitch_1 : MonoBehaviour
{
    public char nota;

    // Start is called before the first frame update
    private void Start()
    {
        switch (nota)
        {
            case 'A':
            case 'a':
                Debug.Log("Sobresaliente");
                break;

            case 'B':
            case 'b':
                Debug.Log("Notable");
                break;

            case 'C':
            case 'c':
                Debug.Log("Aprobado");
                break;

            case 'D':
            case 'd':
                Debug.Log("Aprobado casi suspenso");
                break;

            case 'F':
            case 'f':
                Debug.Log("Suspenso");
                break;

            default:
                Debug.Log("Error: El valor introducido no es valido");
                break;
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}