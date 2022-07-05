using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderTest : MonoBehaviour
{
    public Slider mySlider;
    public Image ImageToFill;

    public void SliderChange()
    {
        ImageToFill.fillAmount = mySlider.value;
    }
}