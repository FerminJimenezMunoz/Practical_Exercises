using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTest : MonoBehaviour
{
    public void PressBotton(string nombre)
    {
        Debug.Log($"Pulsa el botón con el numero {nombre}");
    }
}