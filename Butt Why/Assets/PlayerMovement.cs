using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float MovementSpeed = 500f;

    private void FixedUpdate()
    {
       if ( Input.GetKey("d") )
        {
            rb.AddForce(MovementSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-MovementSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, MovementSpeed * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -MovementSpeed * Time.deltaTime);
        }

    }
}
