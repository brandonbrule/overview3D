using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{

    Animator m_Animator;

    void Start()
    {
        //This gets the Animator, which should be attached to the GameObject you are intending to animate.
        m_Animator = gameObject.GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");


        // Left
        if(x > 0f){
            Debug.Log("x > 0");
        }

        // Right
        if(x < 0f){
            Debug.Log("x < 0");
        }

        // Up
        if(z < 0f){
            Debug.Log("Up");
            m_Animator.SetBool("Walking_Y", true);
        }

        // Down
        if(z > 0f){
            Debug.Log("Down");
            m_Animator.SetBool("Walking_Y", false);
        }


        // Is Moving In Any Direction
        if(x != 0 || z != 0){
            m_Animator.SetBool("is_Walking", true);
        } else {
            m_Animator.SetBool("is_Walking", false);
        }


    }
}
