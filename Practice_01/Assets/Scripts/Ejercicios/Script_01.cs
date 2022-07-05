using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_01 : MonoBehaviour
{
    public Rigidbody[] Rbs;
    public GameObject miGameObject;

    // Start is called before the first frame update
    private void Start()
    {
        Rbs = gameObject.GetComponentsInChildren<Rigidbody>();
    }
}