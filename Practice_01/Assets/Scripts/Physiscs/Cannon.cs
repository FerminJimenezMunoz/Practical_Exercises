using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public Transform ShootPoint;
    public GameObject CannonBall;
    public float CannonForce;

    // Start is called before the first frame update
    private void Start()
    {
        Time.timeScale = 0.5f;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(CannonBall, ShootPoint.position, ShootPoint.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(ShootPoint.forward * CannonForce, ForceMode.Impulse);
            }
        }
    }
}