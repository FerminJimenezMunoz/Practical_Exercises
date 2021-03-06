using UnityEngine;
using System.Collections;

public class DuckMovement : MonoBehaviour
{
    private float speed = .1f;
    public Vector3 direction;

    private bool paused;

    private int bounce;
    public int bounceMax;
    private Shooter shoot;

    private SpriteRenderer duckSprite;

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        duckSprite = GetComponent<SpriteRenderer>();
        GameObject shooter = GameObject.Find("Main Camera");
        shoot = shooter.GetComponent<Shooter>();
        bounce = 0;
        GameManager.OnDuckShot += StopMovement;
        GameManager.OnDuckMiss += FlyAway;
        RandomDirection();
        paused = false;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.P) || Input.GetKeyUp(KeyCode.Escape))
        {
            paused = !paused;
            if (paused)
                duckSprite.enabled = false;
            if (!paused)
                duckSprite.enabled = true;
        }

        if (paused)
        {
            Time.timeScale = 0;
        }
    }

    private void FixedUpdate()
    {
        if (!paused)
        {
            Time.timeScale = 1;
            transform.position = transform.position + (direction * (speed + StaticVars.roundNum / 10));
        }
    }

    public void RandomDirection()
    {
        direction = new Vector3(Random.Range(-1f, 1f), Random.Range(.2f, 1f), 0);

        if (direction.x > 0 && direction.y > 0)
            anim.SetBool("IsUpRight", true);
        if (direction.x < 0 && direction.y > 0)
            anim.SetBool("IsUpLeft", true);
        if (direction.x > 0 && direction.y < 0)
            anim.SetBool("IsSideRight", true);
        if (direction.x < 0 && direction.y < 0)
            anim.SetBool("IsSideLeft", true);
    }

    public void DirectionChanger(Vector3 _dir)
    {
        direction = new Vector3(direction.x * _dir.x, direction.y * _dir.y, 0);

        if (direction.x > 0 && direction.y > 0)
            anim.SetBool("IsUpRight", true);
        if (direction.x < 0 && direction.y > 0)
            anim.SetBool("IsUpLeft", true);
        if (direction.x > 0 && direction.y < 0)
            anim.SetBool("IsSideRight", true);
        if (direction.x < 0 && direction.y < 0)
            anim.SetBool("IsSideLeft", true);

        bounce++;

        if (bounce >= bounceMax)
        {
            direction = new Vector3(0, 1, 0);
            anim.SetBool("IsUpRight", true);
            GameManager.OnDuckMiss();
        }
    }

    public void StopMovement()
    {
        direction = new Vector3(0, 0, 0);
    }

    public void StartFall()
    {
        direction = new Vector3(0, -1, 0);
    }

    public void FlyAway()
    {
        direction = new Vector3(0, 1, 0);
    }
}