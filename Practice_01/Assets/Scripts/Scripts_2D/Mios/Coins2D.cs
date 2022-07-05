using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins2D : MonoBehaviour
{
    public LayerMask PlayerLayer;
    public int CoinValue;
    public float DestroyTime;
    private Collider2D myCollider;
    private AudioSource myAudio;
    private SpriteRenderer myRenderer;

    private void Start()
    {
        myCollider = GetComponentInChildren<Collider2D>();
        myAudio = GetComponentInChildren<AudioSource>();
        myRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Utils.IsInLayerMask(collision.gameObject, PlayerLayer))
        {
            PlayerCoins2D playerCoins2D = collision.GetComponent<PlayerCoins2D>();
            if (playerCoins2D != null)
            {
                GetCoin(playerCoins2D);
            }
        }
    }

    public void GetCoin(PlayerCoins2D playerCoins2D)
    {
        playerCoins2D.AddCoins(CoinValue);
        myCollider.enabled = false;
        myRenderer.enabled = false;
        myAudio.Play();
        Destroy(gameObject, DestroyTime);
    }
}