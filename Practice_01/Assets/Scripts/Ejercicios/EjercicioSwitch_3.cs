using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioSwitch_3 : MonoBehaviour
{
    public int zodiaco;

    // Start is called before the first frame update
    private void Start()
    {
        switch (zodiaco)
        {
            case 1:
                Debug.Log("Signo Aries, categoria Fuego");
                break;

            case 2:
                Debug.Log("Signo Tauro, categoria Tierra");
                break;

            case 3:
                Debug.Log("Signo Géminis, categoria Aire");
                break;

            case 4:
                Debug.Log("Signo Cáncer, categoria Agua");
                break;

            case 5:
                Debug.Log("Signo Leo, categoria Fuego");
                break;

            case 6:
                Debug.Log("Signo Virgo, categoria Tierra");
                break;

            case 7:
                Debug.Log("Signo Libra, categoria Aire");
                break;

            case 8:
                Debug.Log("Signo Escorpio, categoria Agua");
                break;

            case 9:
                Debug.Log("Signo Sagitario, categoria Fuego");
                break;

            case 10:
                Debug.Log("Signo Capricornio, categoria Tierra");
                break;

            case 11:
                Debug.Log("Signo Acuario, categoria Aire");
                break;

            case 12:
                Debug.Log("Signo Piscis, categoria Agua");
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