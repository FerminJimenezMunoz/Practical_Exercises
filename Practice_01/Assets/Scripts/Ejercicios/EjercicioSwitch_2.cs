using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioSwitch_2 : MonoBehaviour
{
    public char caracter;

    // Start is called before the first frame update
    private void Start()
    {
        switch (caracter)
        {
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U':
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Debug.Log("Es una Vocal");
                break;

            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
            case '0':
                Debug.Log("Es un Digito");
                break;

            default:
                Debug.Log("El caracter no es una Vocal o Digito");
                break;
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}