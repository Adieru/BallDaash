using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{

    //Obstacle
    GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle"); 

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Invisible"))
        {
            for(int i = 0; i < obstacles.Length; i++)
            {
                obstacles[i].GetComponent<BoxCollider>().isTrigger = true;
            }
        }
    }
}
