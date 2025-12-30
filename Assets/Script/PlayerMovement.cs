using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //Rigidbody for the player
    public Rigidbody rb;

    //Velocity of the player
    public float velocity;

    //Force of the jump
    public float jumpForce;

    //The speed at which the player can move left and right
    public float sideSpeed;

    //The maximum distance the player can move left and right
    public float SideDistance;

    //The current position of the player
    private float currentX;

    //Boolean to check if the player is on the ground
    bool isGrounded;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Movement
        PlayerMove();
        PlayerJump();

    }

    void PlayerMove()
    {
        //Getting the input from the player
        float horizontalInput = Input.GetAxis("Horizontal");

        //Constantly moving the player forward
        rb.velocity = new Vector3(horizontalInput * sideSpeed, rb.velocity.y, velocity);


    }

    void PlayerJump()
    {

        //Checking for jump input
        bool JumpInput = Input.GetKeyDown(KeyCode.Space);

        //Check if the player is on ground and the jump button is pressed
        if(isGrounded && JumpInput)
        {
            //Applying the jump force
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            isGrounded = false;
        }


    }

    //Collision detection
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground_1")
        {
            isGrounded = true;
        }



    }

}
