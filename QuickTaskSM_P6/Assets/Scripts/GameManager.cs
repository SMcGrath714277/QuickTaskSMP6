using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject projectile;
    private float spawnRangeX = 15;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = .5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnProjectile", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnProjectile()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(projectile, spawnPos, projectile.transform.rotation);
    }
}
