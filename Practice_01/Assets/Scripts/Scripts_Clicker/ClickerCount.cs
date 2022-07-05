using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickerCount : MonoBehaviour
{
    public Text CounterText;
    public int NumerosDeClicks;

    public void SumaClicks(int clicksASumar)
    {
        NumerosDeClicks += clicksASumar;
        CounterText.text = NumerosDeClicks.ToString();
    }
}