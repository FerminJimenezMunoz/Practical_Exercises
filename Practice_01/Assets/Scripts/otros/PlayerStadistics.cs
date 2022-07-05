using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStadistics : MonoBehaviour
{
    private int NumerosDeMonedas = 0;
    public Text MarcadorMonedas;

    public void SumaMonedas(int monedasASumar)
    {
        NumerosDeMonedas += monedasASumar;
        MarcadorMonedas.text = NumerosDeMonedas.ToString();
    }
}