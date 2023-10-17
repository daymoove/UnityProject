using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Level : MonoBehaviour
{
    int level = 1;
    int experience = 0;
    public ExpBar expbar;
    public GameObject levellayout;
    public GameObject buttonupgrade1;
    public GameObject buttonupgrade2;
    [HideInInspector]public List<string> buttonName = new List<string>() {"WhipDamage","WhipSpeed","HealthRegen", "AddKnife", "AddGarlick"};
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
            int text1num = RandomButton(buttonName.Count-1);
            int text2num = RandomButton(buttonName.Count-1);
            
            if (text2num == text1num && text1num!=buttonName.Count-1)
            {
                text2num++;
            } else if (text2num == text1num && text1num == buttonName.Count - 1)
            {
                text2num--;
            }
            buttonupgrade1.GetComponentInChildren<TMP_Text>().text = buttonName[text1num];
            buttonupgrade2.GetComponentInChildren<TMP_Text>().text = buttonName[text2num];
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

    public int RandomButton(int maxbutton)
    {
        int num = Random.Range(0, maxbutton);

        return num;
    }
}
