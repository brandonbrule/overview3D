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

        if (Input.GetKeyDown(KeyCode.A))
        {
            m_Animator.SetBool("is_Walking", true);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            m_Animator.SetBool("is_Walking", false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            m_Animator.SetBool("is_Walking", true);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            m_Animator.SetBool("is_Walking", false);
        }



        if (Input.GetKeyDown(KeyCode.W))
        {
            m_Animator.SetBool("Walking_Y", false);
            m_Animator.SetBool("is_Walking", true);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            m_Animator.SetBool("Walking_Y", false);
            m_Animator.SetBool("is_Walking", false);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            m_Animator.SetBool("Walking_Y", true);
            m_Animator.SetBool("is_Walking", true);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            m_Animator.SetBool("Walking_Y", true);
            m_Animator.SetBool("is_Walking", false);
        }

    }
}
