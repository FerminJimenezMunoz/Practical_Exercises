using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerBar : MonoBehaviour
{
    public Image timerImage;
    public float FillTime;
    private float ElapsedTime;

    private void Start()
    {
        timerImage.fillAmount = 1;
    }

    public void Restart()
    {
        ElapsedTime = 0;
        timerImage.fillAmount = 1;
    }

    private void Update()
    {
        if (ElapsedTime < FillTime)
        {
            ElapsedTime += Time.deltaTime;
            timerImage.fillAmount = Mathf.Lerp(1, 0, ElapsedTime / FillTime);
        }
    }
}
