using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_03 : MonoBehaviour
{
    public MeshRenderer[] misMeshes;

    // Start is called before the first frame update
    private void Start()
    {
        misMeshes = FindObjectsOfType<MeshRenderer>();
    }
}