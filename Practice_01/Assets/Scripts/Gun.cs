using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Animator GunAnimator;
    public Camera FpsCamera;
    public float GunRange = 50;
    public LayerMask GunMask;
    public GameObject BulletImpactPrefab;
    public float ShootFroce;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        GunAnimator.SetTrigger("ShootTrigger");
        RaycastHit hit;
        if (Physics.Raycast(FpsCamera.transform.position, FpsCamera.transform.forward, out hit, GunRange))
        {
            GameObject impact = Instantiate(BulletImpactPrefab, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impact, 1);
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce((-hit.normal) * ShootFroce);
            }
        }
    }
}