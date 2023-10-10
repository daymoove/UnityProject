using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnpoint;
    public GameObject enemy;
    public float spawnTime = 2f;
    private int randspawn;

 
    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnTime, spawnTime);
    }


    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        randspawn = Random.Range(0, spawnpoint.Length);
        var newenemy = GameObject.Instantiate(enemy,spawnpoint[randspawn].position,transform.rotation);
        newenemy.GetComponent<Enemy>().speed = 1f;
    }
}
