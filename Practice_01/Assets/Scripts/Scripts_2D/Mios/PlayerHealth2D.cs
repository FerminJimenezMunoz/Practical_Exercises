using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth2D : MonoBehaviour
{
    public int PlayerMaxHealth;
    private int playerCurrentHealth;
    private PlayerTeleport2D teleport;
    public Image HealthBar;

    public void RestoreHealth()
    {
        playerCurrentHealth = PlayerMaxHealth;
        UpdateHealthBar();
    }

    private void Start()
    {
        RestoreHealth();
        teleport = GetComponent<PlayerTeleport2D>();
    }

    public void UpdateHealthBar()
    {
        HealthBar.fillAmount = Mathf.InverseLerp(0, PlayerMaxHealth, playerCurrentHealth);
    }

    public void TakeDamage(int damageAmount)
    {
        playerCurrentHealth -= damageAmount;
        if (playerCurrentHealth > 0)
        {
            UpdateHealthBar();
        }
        else
        {
            RestoreHealth();

            teleport.TeleportToInitialPosition();
        }
    }
}