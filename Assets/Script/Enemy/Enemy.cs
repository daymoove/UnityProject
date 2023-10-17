using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    private Vector3 targetPosition;
    public float speed;
    public GameObject exp;
    public float hp = 1;
    public int damage = 1;
    Player targetplayer;
    
    void Update()
    {
        targetPosition = player.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;

        if (hp < 1)
        {
            Destroy(gameObject);
            var newexp = GameObject.Instantiate(exp, gameObject.transform.position, transform.rotation);
        }
    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            Attack();
        }
    }

    private void Attack()
    {
        if (targetplayer == null)
        {
            targetplayer = player.GetComponent<Player>();
        }

        targetplayer.TakeDamage(damage);
    }
}
