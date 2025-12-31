using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //Rigidbody for the player
    public Rigidbody rb;

    //To get the transform of the player
    public Transform playerTransform;

    //Velocity of the player
    public float velocity;

    //Force of the jump
    public float jumpForce;

    //The speed at which the player can move left and right
    public float sideSpeed;

    //The distance moved by the player
    private float Distance;

    //Getting movement
    private Vector3 Movement;

    //Boolean to check if the player is on the ground
    bool isGrounded;

    //Check if player has jumped
    bool jumped;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //Movement
        PlayerMove();
        PlayerJump();

    }

    void Update()
    {

        //The distance moved by the player
        Distance = playerTransform.position.z;

        //Getting the input from the player
        float horizontalInput = Input.GetAxis("Horizontal");
        //Getting values
        Movement = new Vector3(horizontalInput * sideSpeed, rb.velocity.y, velocity);


        //Jump check
        CheckJump();

    }

    void PlayerMove()
    {

        //Constantly moving the player
        rb.velocity = Movement;

    }

    void PlayerJump()
    {

        if (jumped)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            jumped = false;
        }

    }

    //Checking for the jump conditions
    void CheckJump()
    {
        //Checking for jump input
        bool JumpInput = Input.GetKeyDown(KeyCode.Space);

        //Check if the player is on ground and the jump button is pressed
        if (isGrounded && JumpInput)
        {
            //Applying the jump force
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            jumped = true;
            isGrounded = false;
        }
    }

    //Increase speed over time
    void incrementSpeed()
    {

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
