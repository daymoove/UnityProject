using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player_move : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    private Vector3 movementVector;
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        movementVector = new Vector3();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        movementVector.x = Input.GetAxisRaw("Horizontal");
        movementVector.y = Input.GetAxisRaw("Vertical");

        movementVector *= speed;

        rigidbody2d.velocity = movementVector;
    }
}
