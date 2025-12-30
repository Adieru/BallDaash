using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //Rigidbody for the player
    public Rigidbody rb;

    //Velocity of the player
    public float velocity;

    //The speed at which the player can move left and right
    public float sideSpeed;

    //The maximum distance the player can move left and right
    public float SideDistance;

    //The current position of the player
    private float currentX;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Giving the player a constant forward velocity
        rb.velocity = new Vector3(0, 0, velocity);

    }

    void PlayerMove()
    {
        //Getting the input from the player
        
    }

}
