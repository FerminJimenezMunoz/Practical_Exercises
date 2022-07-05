using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager2D : MonoBehaviour
{
    public Animator myAnimator;
    private string currentState;
    private const string WalkString = "Run";
    private const string AttackString = "Attack";
    private const string JumpString = "Jump";
    private const string IdleString = "Idle";

    public void JumpAnimation()
    {
        LaunchAnimation(JumpString);
    }

    public void AttackAnimation()
    {
        LaunchAnimation(AttackString);
    }

    public void IdleAnimation()
    {
        LaunchAnimation(IdleString);
    }

    public void WalkingAnimation()
    {
        LaunchAnimation(WalkString);
    }

    public void LaunchAnimation(string newState)
    {
        if (newState == currentState)
        {
            return;
        }
        currentState = newState;
        myAnimator.Play(newState);
    }
}