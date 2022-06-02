using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject bulletprebs;
    public float minSpawntime = 0.0f;
    public float maxSpawntime = 2.0f;

    private Transform target;
    private float lastSpawntime;
    private float spawnDelay;
    
    void Start()
    {
        lastSpawntime = 0.0f;
        target = FindObjectOfType<PlayerController>().transform;
        spawnDelay = Random.Range(minSpawntime, maxSpawntime);
    }

    
    void Update()
    {
        lastSpawntime += Time.deltaTime;

        if (lastSpawntime >= spawnDelay)
        {
            lastSpawntime = 0;

            GameObject bullet = Instantiate(bulletprebs, transform.position, transform.rotation);
            bullet.transform.LookAt(target);

            spawnDelay = Random.Range(minSpawntime, maxSpawntime);
        }
    }
}
