using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_With_Switch : MonoBehaviour
{
    public bool RemainsOpen;
    private bool isWorking;
    public float TimeToOpen, TimeToClose, TimeBeforeClosing;
    public Transform Door, InitialPos, FinalPos;

    public IEnumerator OpenDoor()
    {
        float elapsedTime = 0;

        while (elapsedTime < TimeToOpen)
        {
            elapsedTime += Time.deltaTime;
            Door.position = Vector3.Lerp(InitialPos.position, FinalPos.position, elapsedTime / TimeToOpen);
            yield return null;
        }

        if (!RemainsOpen)
        {
            yield return new WaitForSeconds(TimeBeforeClosing);
            DeactivateDoor();
        }
    }

    public IEnumerator CloseDoor()
    {
        float elapsedTime = 0;
        while (elapsedTime < TimeToClose)
        {
            elapsedTime += Time.deltaTime;
            Door.position = Vector3.Lerp(FinalPos.position, InitialPos.position, elapsedTime / TimeToClose);
            yield return null;
        }
        isWorking = false;
    }

    public void ActivateDoor()
    {
        if (!isWorking)
        {
            StartCoroutine(OpenDoor());
            isWorking = true;
        }
    }

    public void DeactivateDoor()
    {
        StartCoroutine(CloseDoor());
    }
}