using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    bool crouch = false;
    float horizontalMove = 0f;
    bool jump = false;
    public float runSpeed = 16f;
    void Start()
    {

        
    }

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal")*runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
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
    void FixedUpdate()
    {
        controller.Move(horizontalMove*Time.fixedDeltaTime,crouch,jump);
        jump = false;
        
    }   

}
