using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    private float startDelay = 1.0f;

    private float spawnInterval;
    // Split spawnInterval into a minimum and maximum value to use in a random range in "SpawnRandomBall"
    private int minSpawnInterval = 3;
    private int maxSpawnInterval = 5;

    // Start is called before the first frame update
    void Start()
    {
        // Changed to include two variables in a random range instead of just one
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Allow ball spawn to be any of the three in the ballPrefabs Array
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        
        // Set new range of spawn intervals using newly created integers
        spawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
            
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
        
        // Invoke the next spawn after initial Invoke
        Invoke("SpawnRandomBall", spawnInterval);
    }

}
