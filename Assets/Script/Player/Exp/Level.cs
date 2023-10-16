using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    int level = 1;
    int experience = 0;
    public ExpBar expbar;
    public GameObject levellayout;

    int TO_LEVEL_UP
    {
        get
        {
            return level * 1000;
        }
    }

    private void Start()
    {
        expbar.UpdateExperienceSlider(experience, TO_LEVEL_UP);
        expbar.SetLevelText(level);
    }

    public void AddExp(int amount)
    {
        experience += amount;
        CheckLevelUp();
        expbar.UpdateExperienceSlider(experience, TO_LEVEL_UP);
    }

    public void CheckLevelUp()
    {
        if (experience >= TO_LEVEL_UP)
        {
            experience -= TO_LEVEL_UP;
            level += 1;
            expbar.SetLevelText(level);
            levellayout.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ExpOrbe")
        {
            AddExp(400);
        }
    }
}
