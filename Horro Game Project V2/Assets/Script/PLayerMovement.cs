using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float spSpeed = 15f;
    public float gravity = -9.81f;

    // Creates a Sphere for groundCheck that will detect if it is on the floor or not
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    // Update is called once per frame
    void Update()
    {

        
        // Checks if it is grounded
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        // Gets the X and Z variable
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //Allows you to move in any direction your looking
        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);


        if (controller.isGrounded && Input.GetKey("left shift") || Input.GetKey("right shift"))
        {
            speed = spSpeed;

        }


    }

}

   
