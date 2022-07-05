using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAnimationTest : MonoBehaviour
{
    public Animator myAnimator;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            myAnimator.SetBool("IsWorking", false);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            myAnimator.SetBool("IsWorking", true);
        }
    }
}