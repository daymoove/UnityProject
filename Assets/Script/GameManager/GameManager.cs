using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float timer;
    private bool timeron;
    public GameObject Pause;
    public GameObject WinScreen;
    public TMP_Text Timertxt;
    public NewSpawner spawner;
    public Enemy enemy;
    void Start()
    {
        timer = 0f;
        timeron = true;
    }


    void Update()
    {
        if (timeron)
        {
            if (timer < 900)
            {
                timer += Time.deltaTime;
                TimeUpdate(timer);
                EnemyUpgrade(timer);
            }
            else
            {
                WinScreen.SetActive(true);
                timeron = false;
                Time.timeScale = 0f;
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            Pause.SetActive(true);
        }
    }

    private void TimeUpdate(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float secondes = Mathf.FloorToInt(currentTime % 60);

        Timertxt.text = string.Format("{0:00} : {1:00}", minutes, secondes);
    }

    private void EnemyUpgrade(float currentTime)
    {
        if (currentTime%300 == 0)
        {
            enemy.damage *= 2;
            enemy.hp *= 5;
            spawner.timer--;
        }
    }
}
