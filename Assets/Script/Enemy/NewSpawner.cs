using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSpawner : MonoBehaviour
{

    public GameObject enemy;
    public Vector2 spawnarea;
    public float spawntimer;
    private float timer;
    public GameObject player;



    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0f)
        {
            SpawnEnemy();
            timer = spawntimer;
        }
    }

    private void SpawnEnemy()
    {
        Vector3 position = GenerateRandomPosition();

        position += player.transform.position;

        GameObject newenemy = Instantiate(enemy);
        newenemy.transform.position = position;
        newenemy.GetComponent<Enemy>().speed = 1f;
        newenemy.transform.parent = transform;
    }

    private Vector3 GenerateRandomPosition()
    {
        Vector3 position = new Vector3();

        float f = Random.value > 0.5f ? -1f : 1f;

        if (Random.value > 0.5f)
        {
            position.x = Random.Range(-spawnarea.x, spawnarea.y);
            position.y = spawnarea.y * f;
        } else
        {
            position.y = Random.Range(-spawnarea.y, spawnarea.x);
            position.x = spawnarea.x * f;
        }
        position.z = 0f;

        return position;
    }
}
