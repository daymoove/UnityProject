using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarlickWeapon : MonoBehaviour
{
    public float attackSize = 3f;
    int damage = 1;
    private float timer;
    private float timetoattack = 2f;
    public GameObject circle;
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0f)
        {
            Attack();
        }
    }

    public void Attack()
    {
        timer = timetoattack;
        circle.SetActive(true);
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, attackSize);
        ApllyDamage(colliders);
    }

    private void ApllyDamage(Collider2D[] colliders)
    {

        for (int i = 0; i < colliders.Length; i++)
        {
            Enemy ed = colliders[i].GetComponent<Enemy>();
            if (ed != null)
            {
                colliders[i].GetComponent<Enemy>().TakeDamage(damage);
            }
        }
    }
}
