using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int MaxHealth =100;
    public int currentHealth;
    private PlayerTeleport myPlayeTeleport;
    private countdownCounter countDown;
    public Text lifeText;
    public LifeBar myBar;
    public TimerBar myTimerBar;

    // Start is called before the first frame update
    private void Start()
    {
        lifeText.text = currentHealth.ToString("100");
        RestoreHealth();
        myPlayeTeleport = GetComponent<PlayerTeleport>();
        countDown = GetComponent<countdownCounter>();
        myBar.FillLife = MaxHealth;
        myBar.nowLife = MaxHealth;

    }

    public void RestoreHealth()
    {
        currentHealth = MaxHealth;
        myBar.FillLife = MaxHealth;
        myBar.nowLife = MaxHealth;
        lifeText.text = currentHealth.ToString("0");
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth <= 0)
        {
            Debug.Log("Hemos Muerto");
            RestoreHealth();
            myPlayeTeleport.TeleportToInitialPosotion();
            countDown.RestartCountDown();
            myTimerBar.Restart();
        }
        else
        {
            myBar.nowLife = currentHealth;
            lifeText.text = currentHealth.ToString("0");
        }
    }
}