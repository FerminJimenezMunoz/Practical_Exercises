using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport2D : MonoBehaviour
{
    private Vector3 InitialPosition;

    private void Start()
    {
        InitialPosition = transform.position;
    }

    public void Teleport(Vector3 newPosition)
    {
        transform.position = newPosition;
    }

    public void TeleportToInitialPosition()
    {
        Teleport(InitialPosition);
    }
}