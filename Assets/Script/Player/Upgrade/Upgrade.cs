using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{

    public GameObject whip;
    public GameObject knife;
    public GameObject garlick;

   public void UpgradeWhipDamage()
   {
        whip.GetComponent<WhipWeapon>().whipDamage += 1;
        gameObject.SetActive(false);
        Time.timeScale = 1f;
   }
    public void UpgradeKinfeDamage()
    {
        whip.GetComponent<WhipWeapon>().whipDamage += 1;
        gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    public void UpgradeGarlickDamage()
    {
        whip.GetComponent<WhipWeapon>().whipDamage += 1;
        gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
}
