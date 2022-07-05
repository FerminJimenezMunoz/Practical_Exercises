using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapLauncher2D : MonoBehaviour
{
    public Transform ShootPoint;
    public float TimeToShoot;
    public GameObject TrapPrefab;

    private void Start()
    {
        StartCoroutine(ShootCorruTine());
    }

    public IEnumerator ShootCorruTine()
    {
        while (true)
        {
            yield return new WaitForSeconds(TimeToShoot);
            Instantiate(TrapPrefab, ShootPoint.position, ShootPoint.rotation);
        }
    }
}