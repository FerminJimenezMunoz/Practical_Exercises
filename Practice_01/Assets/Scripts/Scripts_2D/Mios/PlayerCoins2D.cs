using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCoins2D : MonoBehaviour
{
    private int NumberOfCoins;
    public Text NumberOfCoinsText;

    public void AddCoins(int coinsToAdd)
    {
        NumberOfCoins += coinsToAdd;
        NumberOfCoinsText.text = NumberOfCoins.ToString();
    }
}