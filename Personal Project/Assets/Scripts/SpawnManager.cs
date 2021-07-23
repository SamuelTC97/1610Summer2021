using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    public GameObject consumaball;
    // Min spawns temporarily not in use until better spawning solution is found
    private float xMin = 18f;
    private float zMin = 18f;
    private float xMax = 24f;
    private float zMax = 22.5f;
    private float ySpawn = .540f;
    private float spawnTime = 1f;
    private float startDelay = 1f;
        // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelay, spawnTime);
        InvokeRepeating("SpawnConsumaball", startDelay, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-xMax, xMax);
        float randomZ = Random.Range(-zMax, zMax);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, randomZ);

        Instantiate(enemy, spawnPos, enemy.gameObject.transform.rotation);
    }

    void SpawnConsumaball()
    {
        float randomX = Random.Range(-xMax, xMax);
        float randomZ = Random.Range(-zMax, zMax);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, randomZ);
        
        Instantiate(consumaball, spawnPos, consumaball.gameObject.transform.rotation);
    }
}
