using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2D : MonoBehaviour
{
    public Transform Door, FinalPos;
    private Vector3 InitialPos;
    public float OpenTime, CloseTime;
    public bool RemainOpen;
    private bool IsOpening = false;

    public void Start()
    {
        InitialPos = Door.transform.position;
    }

    public IEnumerator OpenDoorCorrutine()
    {
        float elapsedTime = 0;
        while (elapsedTime < OpenTime)
        {
            elapsedTime += Time.deltaTime;
            yield return null;
            Door.position = Vector3.Lerp(InitialPos, FinalPos.position, elapsedTime / OpenTime);
        }
        if (!RemainOpen)
        {
            StartCoroutine(CloseDoorCorrutine());
        }
    }

    public void OpenDoor()
    {
        if (!IsOpening)
        {
            IsOpening = true;
            StartCoroutine(OpenDoorCorrutine());
        }
    }

    public IEnumerator CloseDoorCorrutine()
    {
        float elapsedTime = 0;
        while (elapsedTime < CloseTime)
        {
            elapsedTime += Time.deltaTime;
            yield return null;
            Door.position = Vector3.Lerp(FinalPos.position, InitialPos, elapsedTime / CloseTime);
        }
        IsOpening = false;
    }
}