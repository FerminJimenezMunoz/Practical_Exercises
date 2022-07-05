using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearLauncher : MonoBehaviour
{
    public GameObject SpearPrefab;
    public Transform LaunchPoint;

    public float TimeToLaunchSpear;
    public float ElapsedTime = 10;

    // Start is called before the first frame update
    private void Start()
    {
        GameObject spear = Instantiate(SpearPrefab, LaunchPoint.position, LaunchPoint.rotation);
    }

    // Update is called once per frame
    private void Update()
    {
        ElapsedTime += Time.deltaTime;
        if (ElapsedTime > TimeToLaunchSpear)
        {
            GameObject spear = Instantiate(SpearPrefab, LaunchPoint.position, LaunchPoint.rotation);
            ElapsedTime = 0;
        }
    }
}