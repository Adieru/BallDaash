using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class ObstacleManager : MonoBehaviour
{
    //The amount of tries the player gets
    public int playerTries = 3;
    public Vector3 SpawnPosition;

    public bool ObstacleDmg;

    bool hasCollided = false;

    public float InitialVel;

    //Getting movement
    public Rigidbody Player;

    //Player Movment script
    public PlayerMovement playerMvt;

    //Collision check for obstacles
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {

            if (ObstacleDmg)
            {
                playerTries--;

                playerMoveBack(playerTries);
            }

        }
    }

    //Moving the player back upon hitting an obstacle
    void playerMoveBack(int tries)
    {
        if (tries <= 0)
        {
            //GameOver
            playerMvt.HighScoreKeep();


            //Coin Update
            CoinChange();

        }

        else
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            hasCollided = true;
        }

    }

    //Coins 
    void CoinChange()
    {
        if(!PlayerPrefs.HasKey("Coins"))
        {
            PlayerPrefs.SetInt("Coins", this.GetComponent<CoinManagement>().coinCount);
        }

        else
        {
            int currentCoins = PlayerPrefs.GetInt("Coins");
            currentCoins += this.GetComponent<CoinManagement>().coinCount;
            PlayerPrefs.SetInt("Coins", currentCoins);
        }
    }

}
