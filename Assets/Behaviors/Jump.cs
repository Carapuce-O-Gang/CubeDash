using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float speed = 0.1f;
    public float jumpSpeed = 6f;
    public float distToGround = 0.5f;
    public bool x, z;
    public bool reverseSpeed = false;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (reverseSpeed)
        {
            speed = speed * -1;
        }
        if (Input.GetKey(KeyCode.Space) && isGrounded())
        {
            rb.AddForce(new Vector3(0,jumpSpeed), ForceMode.Impulse);
        }
        
        if (x)
        {
            Vector3 movementX = new Vector3(speed, 0, 0);
            rb.MovePosition(transform.position + movementX);
        }
        else if (z)
        {
            Vector3 movementZ = new Vector3(0, 0, speed);
            rb.MovePosition(transform.position + movementZ);
        }
    }
    bool isGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, distToGround);
    }
}
