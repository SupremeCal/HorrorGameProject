using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterControl : MonoBehaviour
{
    public float Speed;

    Rigidbody rb;

    //float hor;
    //float ver;

    //Vector3 velocity;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update ()
    {

  
        //PlayerMovement();


        //float s = Speed * Time.deltaTime;
       


        //velocity.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        //velocity.z = Input.GetAxis("Vertical") * Speed * Time.deltaTime;

    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = Camera.main.transform.forward * Speed * Time.deltaTime;
        }
        else
        {
            rb.velocity = transform.forward * 0;
        }

        //PlayerMovementPhysics();

    }

    void PlayerMovement()
    {

        //Vector3 playerMovement = new Vector3(hor, 0f, ver) ;
        //transform.Translate(playerMovement, Space.Self);
    }

    void PlayerMovementPhysics()
    {
        //rb.MovePosition(transform.position + velocity);
    }
}