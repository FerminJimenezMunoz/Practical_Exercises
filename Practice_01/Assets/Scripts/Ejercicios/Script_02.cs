using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_02 : MonoBehaviour
{
    public GameObject miGameObject;

    public MeshRenderer miMeshRenderer;

    // Start is called before the first frame update
    private void Start()
    {
        miMeshRenderer = miGameObject.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
    }
}