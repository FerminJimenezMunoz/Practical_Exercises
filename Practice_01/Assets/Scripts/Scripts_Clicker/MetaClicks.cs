using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MetaClicks : MonoBehaviour
{
    public int MetadeClicks;
    private string cambiodeIntaString;
    public Text MetadeClicksText;

    private void Start()
    {
        cambiodeIntaString = MetadeClicks.ToString();
        MetadeClicksText.text = cambiodeIntaString;
    }
}