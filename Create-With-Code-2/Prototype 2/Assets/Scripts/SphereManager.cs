using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereManager : MonoBehaviour
{
    public GameObject sphere;
    private float spawnRangeX = 10;
    private float spawnPosZ = -7.8f;
    private float startDelay = 2;
    private float spawnInterval = 10f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnSphere", startDelay, spawnInterval);
    }

    void SpawnSphere()
    {
        if(GameObject.FindGameObjectsWithTag("Sphere").Length < 1)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate(sphere, spawnPos, sphere.transform.rotation);
        }
        
    }
}
