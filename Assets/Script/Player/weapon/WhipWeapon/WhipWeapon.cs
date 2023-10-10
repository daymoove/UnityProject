using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhipWeapon : MonoBehaviour
{
    public GameObject whipleft;
    public GameObject rightwhip;
    private float timetoattack = 4f;
    private float timer;
    public GameObject player;
    Player_move playermove;
    Vector2 whipattsize = new Vector2(4f, 2f);
    private int whipDamage = 1;


    void Start()
    {
        playermove = player.GetComponent<Player_move>();
    }


    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0f)
        {
            Attack();
        }
    }

    private void Attack()
    {
        
        timer = timetoattack;

        if (playermove.lasthorizontalvector < 0)
        {
            
            whipleft.SetActive(true);
            Collider2D[] colliders = Physics2D.OverlapBoxAll(whipleft.transform.position, whipattsize, 0f);
            ApllyDamage(colliders);
        } else
        {
            rightwhip.SetActive(true);
            Collider2D[] colliders = Physics2D.OverlapBoxAll(rightwhip.transform.position, whipattsize, 0f);
            ApllyDamage(colliders);
        }
    }

    private void ApllyDamage(Collider2D[] colliders)
    {
        
        for (int i = 0; i < colliders.Length; i++)
        {
            Enemy ed = colliders[i].GetComponent<Enemy>();
            if(ed != null)
            {
                colliders[i].GetComponent<Enemy>().TakeDamage(whipDamage);
            }
        }
    }
}
