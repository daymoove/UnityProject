using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAfterTime : MonoBehaviour
{

    private float timetodisable = 0.8f;
    private float timer;
    // Start is called before the first frame update
    private void OnEnable()
    {
        timer = timetodisable;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0f)
        {
            gameObject.SetActive(false);
        }
    }
}
