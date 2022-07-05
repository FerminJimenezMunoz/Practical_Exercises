using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DuckSpawn : MonoBehaviour
{
    public GameObject duck;
    public Transform[] spawnPoints;

    private void Start()
    {
        //spawnPoints = new Vector3
        //      GameManager.OnSpawnDucks += SpawnDuck;
    }

    public void SpawnDuck()
    {
        ////int randomSpawnPointNum = Random.Range (0, spawnPoints.Count-1);
        //Instantiate(duck, spawnPoints[randomSpawnPointNum].position, Quaternion.identity);
    }
}