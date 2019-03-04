﻿using UnityEngine;


public class BouncerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float MovementSpeed = 500f;

    private void FixedUpdate()
    {
       if ( Input.GetKey("right") )
        {
            rb.AddForce(MovementSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("left"))
        {
            rb.AddForce(-MovementSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("up"))
        {
            rb.AddForce(0, 0, MovementSpeed * Time.deltaTime);
        }

        if (Input.GetKey("down"))
        {
            rb.AddForce(0, 0, -MovementSpeed * Time.deltaTime);
        }

    }
}
