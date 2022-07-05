using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingBar1 : MonoBehaviour
{
    public Image LoadingImage;
    public float FillTime;
    private float ElapsedTime;

    private void Start()
    {
        LoadingImage.fillAmount = 1;
    }

    public void Restart()
    {
        ElapsedTime = 0;
    }

    private void Update()
    {
        if (ElapsedTime < FillTime)
        {
            ElapsedTime += Time.deltaTime;
            LoadingImage.fillAmount = Mathf.Lerp(1, 0, ElapsedTime / FillTime);
        }
    }
}