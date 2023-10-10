using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player_move : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    public Vector3 movementVector;
    public float speed = 3f;
    [HideInInspector]
    public float lastverticalvector;
    [HideInInspector]
    public float lasthorizontalvector;

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        movementVector = new Vector3();
        
    }


    void Update()
    {
        
        movementVector.x = Input.GetAxisRaw("Horizontal");
        movementVector.y = Input.GetAxisRaw("Vertical");

        if (movementVector.x != 0)
        {
            lasthorizontalvector = movementVector.x;
        }
        if (movementVector.y != 0)
        {
            lastverticalvector = movementVector.y;
        }

        movementVector *= speed;

        rigidbody2d.velocity = movementVector;
    }
}
