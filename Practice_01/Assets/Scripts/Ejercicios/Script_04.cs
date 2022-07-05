using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_04 : MonoBehaviour
{
    public GameObject miGameObject;

    public MeshRenderer miMesh;

    // Start is called before the first frame update
    private void Start()
    {
        miMesh = GetComponentInChildren<MeshRenderer>();
    }
}