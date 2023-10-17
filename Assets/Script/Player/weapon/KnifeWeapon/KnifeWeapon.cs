using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeWeapon : MonoBehaviour
{
    public float timetoattck;
    float timer;
    public GameObject trowingknife;
    Player_move playermove;
    public GameObject player;
    [HideInInspector]public int knifenumber;
    [HideInInspector]public int damage = 5;


    void Start()
    {
        playermove = player.GetComponent<Player_move>();
        knifenumber = 1;
    }

    private void Update()
    {
        if (timer < timetoattck)
        {
            timer += Time.deltaTime;
            return;
        }

        timer = 0;
        SpawnKnife();
    }

    private void SpawnKnife()
    {
        GameObject knife = Instantiate(trowingknife);
        
        knife.transform.position = transform.position;
        
        if (playermove.lasthorizontalvector < 0)
        {
            knife.transform.rotation =  Quaternion.Euler(0,0,90);
            
        }
        knife.GetComponent<KnifeProjectile>().SetDirection(playermove.lasthorizontalvector, 0f);
        knife.GetComponent<KnifeProjectile>().damage = damage;

        if (knifenumber >= 2)
        {
            GameObject knife2 = Instantiate(trowingknife);
            knife2.transform.position = new Vector2(transform.position.x, transform.position.y + 1);

            if (playermove.lasthorizontalvector < 0)
            {
                knife2.transform.rotation = Quaternion.Euler(0, 0, 90);
            }
            knife2.GetComponent<KnifeProjectile>().SetDirection(playermove.lasthorizontalvector, 0f);
            knife2.GetComponent<KnifeProjectile>().damage = damage;
        }
        if (knifenumber == 3)
        {
            GameObject knife3 = Instantiate(trowingknife);
            knife3.transform.position = new Vector2(transform.position.x, transform.position.y -1 );

            if (playermove.lasthorizontalvector < 0)
            {
                knife3.transform.rotation = Quaternion.Euler(0, 0, 90);
            }
            knife3.GetComponent<KnifeProjectile>().SetDirection(playermove.lasthorizontalvector, 0f);
            knife3.GetComponent<KnifeProjectile>().damage = damage;
        }
    }
}
