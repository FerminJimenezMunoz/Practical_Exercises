using UnityEngine;
using System.Collections;

public class DuckHealth : MonoBehaviour
{
    private Animator anim;
    public bool isInvincible;
    private GameObject shoot;
    private Shooter shooter;

    private void Start()
    {
        //getcomponent
        shoot = GameObject.Find("Main Camera");
        shooter = shoot.GetComponent<Shooter>();
        isInvincible = false;
        anim = gameObject.GetComponent<Animator>();
        GameManager.OnDuckMiss += MakeInvincible;
        GameManager.OnDuckShot += MakeInvincible;
    }

    //void Update () {}

    private void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "KillZone")
        {
            if (StaticVars.duckNum > 10)
            {
                GameManager.OnNewRound();
                Destroy(this.gameObject);
            }
            else
            {
                GameManager.OnDuckDeath();
                Destroy(this.gameObject);
            }
        }
        if (hit.tag == "FlyAwayZone")
        {
            if (StaticVars.duckNum > 10)
            {
                GameManager.OnNewRound();
                Destroy(this.gameObject);
            }
            else
            {
                GameManager.OnDuckFlyAway();
                Destroy(this.gameObject);
            }
        }
        print(StaticVars.duckNum);
    }

    public void KillDuck()
    {
        if (isInvincible == false)
        {
            GameManager.OnDuckShot();
            anim.SetBool("IsDead", true);
        }
    }

    public void MakeInvincible()
    {
        isInvincible = true;
    }
}