using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioMetodo_6 : MonoBehaviour
{
    private char letra1 = 'a';

    // Start is called before the first frame update
    private void Start()
    {
        LetrasAlfabeto(letra1);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void LetrasAlfabeto(char letra)
    {
        for (int i = 0; i < 26; i++)
        {
            Debug.Log(letra);
            letra++;
        }
    }
}