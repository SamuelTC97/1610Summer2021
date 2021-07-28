using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    public GameObject consumaball;
    private float xRange = 24f;
    private float zRange = 22.5f;
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
        float randomX = Random.Range(-xRange, xRange);
        float randomZ = Random.Range(-zRange, zRange);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, randomZ);

        Instantiate(enemy, spawnPos, enemy.gameObject.transform.rotation);
    }

    void SpawnConsumaball()
    {
        float randomX = Random.Range(-xRange, xRange);
        float randomZ = Random.Range(-zRange, zRange);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, randomZ);
        
        Instantiate(consumaball, spawnPos, consumaball.gameObject.transform.rotation);
    }
}
