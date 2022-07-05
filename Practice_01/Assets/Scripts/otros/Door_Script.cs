using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Script : MonoBehaviour
{
    private bool doorKey, openedDoor, closedDoor;
    private float lerpTime = 2, elapsedTime = 5;
    private Collider miCollider;
    public Transform door, initialPos, finalPos;

    private void Start()
    {
        miCollider = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (closedDoor && !doorKey)
        {
            Debug.Log("La Puerta está cerrada, hace falta una llave");
        }
        else if (doorKey == true)
        {
            Debug.Log("Se ha utilizado la llave. (La puerta se abre)");
            miCollider.enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (closedDoor && doorKey)
        {
            openedDoor = true;
            closedDoor = false;
        }
        else
        {
            openedDoor = true;
            closedDoor = false;
        }

        if (openedDoor == true)
        {
            if (elapsedTime < lerpTime)
            {
                elapsedTime += Time.deltaTime;
                door.position = Vector3.Lerp(initialPos.position, finalPos.position, elapsedTime / lerpTime);
            }
        }
    }
}