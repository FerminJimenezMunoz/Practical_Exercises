using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysiscsTesting : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 force;
    public ForceMode mode;
    public Vector3 newGravity;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        Physics.gravity = newGravity;
    }

    // Update is called once per frame
    private void Update()
    {
        rb.AddTorque(force, mode);
    }
}