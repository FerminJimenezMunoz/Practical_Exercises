using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator doorAnimator;
    private bool animatorBoolState = true;

    private void Start()
    {
        doorAnimator = GetComponent<Animator>();
    }

    //La variable no es "IsOpen" es "Abierta" (ya que és el parámetro que esta declarado en el animator de la puerta)
    public void UseDoor()
    {
        doorAnimator.SetBool("Abierta", animatorBoolState);
        animatorBoolState = !animatorBoolState;
    }
}