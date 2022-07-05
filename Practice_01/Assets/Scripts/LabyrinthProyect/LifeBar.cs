using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    public Image lifeImage;
    public float FillLife;
    public float nowLife;

    private void Start()
    {
        lifeImage.fillAmount = 1;
    }

    private void Update()
    {
        if (nowLife <= FillLife)
        {
            lifeImage.fillAmount = Mathf.Lerp(0, 1, nowLife / FillLife);
        }
    }
}
