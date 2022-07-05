using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdownCounter : MonoBehaviour
{
    public float CountDownDuration;
    private float TimeRemaning;
    public PlayerHealth myHealth;
    public Text countdownText;
    public TimerBar myBar;

    private void Start()
    {
        myHealth = GetComponent<PlayerHealth>();
        TimeRemaning = CountDownDuration;
        myBar.FillTime = CountDownDuration;
    }

    public void RestartCountDown()
    {
        TimeRemaning = CountDownDuration;
        myBar.timerImage.fillAmount = 1; 
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
            myHealth.TakeDamage(1000);
            TimeRemaning = CountDownDuration;
            myBar.Restart();
            myBar.FillTime = CountDownDuration;
        }
    }
}