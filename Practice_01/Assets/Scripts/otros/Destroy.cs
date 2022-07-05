using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float LifeTime;

    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(DestroyCorrutine());
    }

    public IEnumerator DestroyCorrutine()
    {
        yield return new WaitForSeconds(LifeTime);
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}