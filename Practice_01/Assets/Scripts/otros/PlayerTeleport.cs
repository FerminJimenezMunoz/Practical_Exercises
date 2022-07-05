using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    private Vector3 initialPos;

    // Start is called before the first frame update
    private void Start()
    {
        initialPos = transform.position;
    }

    public void Teleport(Vector3 newPosotion)
    {
        transform.position = newPosotion;
    }

    public void TeleportToInitialPosotion()
    {
        Teleport(initialPos);
    }
}