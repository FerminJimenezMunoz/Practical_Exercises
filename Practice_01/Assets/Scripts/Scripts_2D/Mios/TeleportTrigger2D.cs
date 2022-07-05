using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTrigger2D : MonoBehaviour
{
    public Transform TeleportToFinalPosition;
    private PlayerTeleport2D playerTele;
    public LayerMask player;

    private void Start()
    {
        playerTele = FindObjectOfType<PlayerTeleport2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Utils.IsInLayerMask(collision.gameObject, player))
        {
            playerTele.Teleport(TeleportToFinalPosition.position);
        }
    }
}