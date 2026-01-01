using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManagement : MonoBehaviour
{
    //Coin count
    private int coinCount = 0;




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            //Increment coin count
            coinCount++;

            //Destroy coin object
            Destroy(collision.gameObject);

        }
    }
}
