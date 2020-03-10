using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    bool crouch = false;
    float horizontalMove = 0f;
    bool jump = false;
    public float runSpeed = 16f;
    public Animator animator;
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal")*runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("isJumping", true);
        }
       
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if(Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        } 
        
    }

    public void onLanding()
    {
        animator.SetBool("isJumping", false);
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove*Time.fixedDeltaTime,crouch,jump);
        jump = false;
    }   

}
