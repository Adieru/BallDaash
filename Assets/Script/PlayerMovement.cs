using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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

    //Text for the score
    public TextMeshProUGUI scoreText;
    //Score
    private int Score;


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


        //Increase speed
        incrementSpeed();

        //Score
        ScoreKeep();

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
        if (Distance % 50f <= 0.01f && Distance % 50f >= 0f)
        {
            velocity += 1;

        }

    }

    //Collision detection
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground_1"))
        {
            isGrounded = true;
        }

    }


    //Score keeping
    void ScoreKeep()
    {
        Score = (int)Distance;

        scoreText.text = "Score: " + Score.ToString();

    }

}
