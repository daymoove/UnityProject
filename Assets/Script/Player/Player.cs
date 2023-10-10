using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHp = 1000;
    public int currentHp = 1000;
    public HPBar hpbar;

    private void Start()
    {
        hpbar.UpdateHPSlider(currentHp, maxHp);
    }

    public void TakeDamage(int damage)
    {
        currentHp -= damage;
        hpbar.UpdateHPSlider(currentHp, maxHp);
        if (currentHp <= 0)
        {
            hpbar.UpdateHPSlider(currentHp, maxHp);
            Debug.Log("You are dead");
        }
    }
}
