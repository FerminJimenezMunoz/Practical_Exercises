using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldTest : MonoBehaviour
{
    public InputField inputField;

    public void OnSumit()
    {
        Debug.Log($"El nombre del jugador es: {inputField.textComponent.text}");
    }
}