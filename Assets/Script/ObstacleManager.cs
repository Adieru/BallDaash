using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObstacleManager : MonoBehaviour
{
    //The amount of tries the player gets
    public int playerTries = 3;
    public Vector3 SpawnPosition;

    public float InitialVel;

    //Getting movement
     public Rigidbody Player;

    //Collision check for obstacles
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Player hit an obstacle!");
            playerTries--;

            

            playerMoveBack(playerTries);



        }
    }

    //Moving the player back upon hitting an obstacle
    void playerMoveBack(int tries)
    {
        if (tries > 0)
        {
            this.transform.position = SpawnPosition;

            //Slowing the player down
            this.Player.velocity = new Vector3(0, 0, InitialVel);

        }

        else
        {
            Debug.Log("Game Over!");
        }

    }

}
