using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeProjectile : MonoBehaviour
{
    Vector3 direction;
    private float speed = 50f;
    public int damage = 5;
    bool hitDetected = false;
    float timer = 0f;

    public void SetDirection(float dir_x, float dir_y)
    {
        
        direction = new Vector3(dir_x, dir_y);

        if (dir_x < 0)
        {
            Vector3 scale = transform.localScale;
            scale.x = scale.x * -1;
            transform.localScale = scale;
        }
    }

    
    private void Update()
    {
        timer += Time.deltaTime;
        if (Time.frameCount % 6 == 0)
        {
            transform.position += direction * speed * Time.deltaTime;
            Collider2D[] hit = Physics2D.OverlapCircleAll(transform.position, 0.3f);
            foreach (Collider2D c in hit)
            {
                Enemy enemy = c.GetComponent<Enemy>();
                if (enemy != null)
                {
                    enemy.TakeDamage(damage);
                    hitDetected = true;
                    break;
                }

            }
            if (hitDetected == true)
            {
                Destroy(gameObject);
            }
        }
        if (timer >= 3)
        {
            timer = 0;
            Destroy(gameObject);
        }

    }
}
