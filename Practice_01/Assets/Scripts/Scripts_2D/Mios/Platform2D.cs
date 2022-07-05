using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform2D : MonoBehaviour
{
    public Transform InitialPosition, FinalPosition, Platform;
    public float WaitTime, LerpTime;
    private float ElapsedTime;

    private void Start()
    {
        StartCoroutine(PlatformCorrutine());
    }

    public void Swapt()
    {
        Transform temp = InitialPosition;
        InitialPosition = FinalPosition;
        FinalPosition = temp;
    }

    public IEnumerator PlatformCorrutine()
    {
        while (true)
        {
            while (ElapsedTime < LerpTime)
            {
                ElapsedTime += Time.deltaTime;
                Platform.position = Vector3.Lerp(InitialPosition.position, FinalPosition.position, ElapsedTime / LerpTime);
                yield return null;
            }
            ElapsedTime = 0;
            Swapt();
            yield return new WaitForSeconds(WaitTime);
        }
    }
}