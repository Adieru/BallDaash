using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //Rigidbody for the player
    public Rigidbody rb;

    //Velocity of the player
    public float velocity;


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
}
