using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadPlayerName : MonoBehaviour
{
    public Text PlayerNameText;

    private void Start()
    {
        LoadName();
    }

    //El  nombre del string estaba mal la “N” es en mayúsculas no minúsculas.
    public void LoadName()
    {
        PlayerNameText.text = PlayerPrefs.GetString("Name");
    }
}