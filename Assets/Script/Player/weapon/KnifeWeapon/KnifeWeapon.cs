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


    void Start()
    {
        playermove = player.GetComponent<Player_move>();
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
    }
}
