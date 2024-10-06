using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//-------------------------------------------------------------------------------
public class PlayerController : MonoBehaviour
{
    public GameController GC;
    CharacterController controller;
    private Vector3 forward, strafe, vertical;
    private float forwardSpeed = 3, strafeSpeed = 5, gravity, maxJumpHeight = 2, timeToMaxHeight = 0.5f;
    public Animator amin1;
    //-------------------------------------------------------------------------------
    void Start()
    {
        GC = GameObject.Find("GameController").GetComponent<GameController>();
        controller = GetComponent<CharacterController>();
        gravity = (-2 * maxJumpHeight) / (timeToMaxHeight * timeToMaxHeight);
    }
    //-------------------------------------------------------------------------------
    void Update()
    {
        Playercontrols();
        //-------------------------------------------------------------------------------
        if (controller.velocity.x != 0 || controller.velocity.z != 0)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                amin1.SetFloat("Andar", 1);
            }
        }
        else
        {
            amin1.SetFloat("Andar", 0);
        }
    }
    //-------------------------------------------------------------------------------
    void Playercontrols()
    {  
        float forwardInput = Input.GetAxisRaw("Vertical");
        float strafeInput = Input.GetAxisRaw("Horizontal");

        forward = forwardInput * forwardSpeed * transform.forward;
        strafe = strafeInput * strafeSpeed * transform.right;

        vertical += gravity * Time.deltaTime * Vector3.up;

        Vector3 finalVelocity = forward + strafe + vertical;
        controller.Move(finalVelocity * Time.deltaTime);
    }
    //-------------------------------------------------------------------------------
}
