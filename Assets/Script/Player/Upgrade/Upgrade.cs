using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Upgrade : MonoBehaviour
{

    public GameObject whip;
    public GameObject knife;
    public GameObject garlick;
    public HPBar hpbar;

    public GameObject buttonupgrade1;
    public GameObject buttonupgrade2;
    public GameObject player;
    Level Levelplayer;

    private void Start()
    {
        Levelplayer = player.GetComponent<Level>();
    }

    public void UpgradeButton1()
    {
        UgradeFunction(buttonupgrade1);
    }

    public void UpgradeButton2()
    {
        UgradeFunction(buttonupgrade2);
    }


    public void UgradeFunction(GameObject buttonupgrade)
    {
        if ("AddKnife" == buttonupgrade.GetComponentInChildren<TMP_Text>().text)
        {
            AddKnife();
        } 
        else if ("AddGarlick" == buttonupgrade.GetComponentInChildren<TMP_Text>().text)
        {
            AddGarlick();
        }
        else if ("WhipDamage" == buttonupgrade.GetComponentInChildren<TMP_Text>().text)
        {
            UpgradeWhipDamage();
        }
        else if ("KnifeDamage" == buttonupgrade.GetComponentInChildren<TMP_Text>().text)
        {
            UpgradeKinfeDamage();
        }
        else if ("GarlicDamage" == buttonupgrade.GetComponentInChildren<TMP_Text>().text)
        {
            UpgradeGarlickDamage();
        }
        else if ("WhipSpeed" == buttonupgrade.GetComponentInChildren<TMP_Text>().text)
        {
            WhipSpeed();
        }
        else if ("GarlickSpeed" == buttonupgrade.GetComponentInChildren<TMP_Text>().text)
        {
            GarlickSpeed();
        }
        else if ("KnifeNumber" == buttonupgrade.GetComponentInChildren<TMP_Text>().text)
        {
            KnifeNumber();
        }
        else if ("HealthRegen" == buttonupgrade.GetComponentInChildren<TMP_Text>().text)
        {
            HealthRegen();
        }
    }


    public void AddKnife()
    {
        knife.SetActive(true);
        Levelplayer.buttonName.Add("KnifeDamage");
        Levelplayer.buttonName.Add("KnifeNumber");
        Levelplayer.buttonName.Remove("AddKnife");
        gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
    public void AddGarlick()
    {
        garlick.SetActive(true);
        Levelplayer.buttonName.Add("GarlicDamage");
        Levelplayer.buttonName.Add("GarlickSpeed");
        Levelplayer.buttonName.Remove("AddGarlick");
        gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    public void UpgradeWhipDamage()
   {
        whip.GetComponent<WhipWeapon>().whipDamage += 1;
        gameObject.SetActive(false);
        Time.timeScale = 1f;
   }
    public void UpgradeKinfeDamage()
    {
        knife.GetComponent<KnifeWeapon>().damage++;
        gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    public void UpgradeGarlickDamage()
    {
        garlick.GetComponent<GarlickWeapon>().damage += 1;
        gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    public void WhipSpeed()
    {
        whip.GetComponent<WhipWeapon>().timetoattack--;
        Levelplayer.buttonName.Remove("WhipSpeed");
        gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    public void GarlickSpeed()
    {
        garlick.GetComponent<GarlickWeapon>().timetoattack--;
        if (garlick.GetComponent<GarlickWeapon>().timetoattack <= 1)
        {
            Levelplayer.buttonName.Remove("GarlickSpeed");
        }
        gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    public void KnifeNumber()
    {
        knife.GetComponent<KnifeWeapon>().knifenumber++;
        if (knife.GetComponent<KnifeWeapon>().knifenumber == 3)
        {
            Levelplayer.buttonName.Remove("KnifeNumber");
        }
        gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    public void HealthRegen()
    {
        Player playerhp = player.GetComponent<Player>();
        if (playerhp.currentHp + 100 > playerhp.maxHp)
        {
            playerhp.currentHp += (playerhp.maxHp - playerhp.currentHp);
            hpbar.UpdateHPSlider(playerhp.currentHp, playerhp.maxHp);
        } else if (playerhp.currentHp >= playerhp.maxHp)
        {
            playerhp.currentHp += 0;
            hpbar.UpdateHPSlider(playerhp.currentHp, playerhp.maxHp);
        } else
        {
            playerhp.currentHp += 100;
            hpbar.UpdateHPSlider(playerhp.currentHp, playerhp.maxHp);
        }
        gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
}
