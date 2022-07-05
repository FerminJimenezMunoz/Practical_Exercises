using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerDown : MonoBehaviour
{
    public float CountDownDuration;
    public float TimeRemaning;
    public Text countdownText;
    public ClickerCount miContador;
    public MetaClicks miMeta;

    private void Start()
    {
        TimeRemaning = CountDownDuration;
    }

    private void Update()
    {
        if (TimeRemaning > 0)
        {
            TimeRemaning -= Time.deltaTime;
            countdownText.text = TimeRemaning.ToString("0.00");
        }
        else
        {
            TimeRemaning = 0;
            if (miContador.NumerosDeClicks >= miMeta.MetadeClicks)
            {
                Debug.Log($"Has ganado");
            }
            else
            {
                Debug.Log($"Has Perdido");
            }
        }
    }
}