using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public Transform platform;
    public Transform initialPos;
    public Transform finalPos;

    public float LerpTime;
    private float elapsedTime;

    public float WaitTime = 2;
    private float timeWaited = 0;

    private void FixedUpdate()
    {
        if (elapsedTime < LerpTime)
        {
            elapsedTime += Time.deltaTime;
            platform.position = Vector3.Lerp(initialPos.position, finalPos.position, elapsedTime / LerpTime);
        }
        else
        {
            timeWaited += Time.deltaTime;
            if (timeWaited > WaitTime)
            {
                SwapPositions();
                elapsedTime = 0;
                timeWaited = 0;
            }
        }
    }

    public void SwapPositions()
    {
        Transform temp = initialPos;
        initialPos = finalPos;
        finalPos = temp;
    }
}