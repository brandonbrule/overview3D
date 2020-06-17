﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;
    private float speed = 11f;
    private float walking = 11f;
    private float running = 21f;
    public float gravity = -9.81f;
    public AudioSource walkingAudio;

    public float jumpHeight = 3f;

    public float groundDistance = 0.4f;

    Vector3 velocity;
    bool isGrounded;
    bool canJump;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        isGrounded = controller.isGrounded;

        if (isGrounded)
        {
            canJump = false;
            
        }

        // Is Walking
        if(x != 0 || z != 0){
            
        } else {
            walkingAudio.Play();
        }

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = running;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = walking;
        }


        if (!canJump)
        {
            if (Input.GetButtonDown("Jump"))
            {
                canJump = true;
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            }
        }



        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
