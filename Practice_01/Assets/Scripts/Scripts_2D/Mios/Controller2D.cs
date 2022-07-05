using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller2D : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    public AnimatorManager2D animatorManager2D;

    private float dirX = 0f;
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 14f;
    [SerializeField] private LayerMask jumpableGround;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        dirX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
        FlipCharacter();
        bool isGrounded = IsGrounded();

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        if (isGrounded)
        {
            if (dirX == 0)
            {
                animatorManager2D.IdleAnimation();
            }
            else
            {
                animatorManager2D.WalkingAnimation();
            }
        }
        else
        {
            animatorManager2D.JumpAnimation();
        }
    }

    public void FlipCharacter()
    {
        if (dirX > 0)
        {
            transform.rotation = Quaternion.identity;
        }
        else if (dirX < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}