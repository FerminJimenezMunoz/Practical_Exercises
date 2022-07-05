using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monedas : MonoBehaviour
{
    public int PuntosASumar = 1;
    private AudioSource audioSources;
    private Collider miCollider;
    private MeshRenderer meshRenderer;

    private void Start()
    {
        audioSources = GetComponentInChildren<AudioSource>();
        miCollider = GetComponentInChildren<Collider>();
        meshRenderer = GetComponentInChildren<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerStadistics playerStadistics = other.GetComponent<PlayerStadistics>();
        if (playerStadistics != null)
        {
            playerStadistics.SumaMonedas(PuntosASumar);
            miCollider.enabled = false;
            meshRenderer.enabled = false;
            audioSources.Play();
            Destroy(gameObject, 10);
        }
    }

    private void OnTriggerExit(Collider other)
    {
    }
}