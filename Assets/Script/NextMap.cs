using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextMap : MonoBehaviour
{
    /*
     private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("MapPass"))
        { 
            Debug.Log("Next Map Triggered");
            // Here you can add code to load the next map or level
        }
    }
    */

    public Transform groundHolder;
    Transform coinHolder;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {

            if (collision.transform.GetSiblingIndex() == 1)
            {
                groundHolder.GetChild(0).transform.position = groundHolder.GetChild(2).transform.position
                                                                + new Vector3(0, 0, 150);

                /*
                coinHolder = groundHolder.GetChild(0).GetChild(0);

                for (int i = 0; i < coinHolder.childCount; i++)
                {
                    coinHolder.GetChild(i).gameObject.SetActive(true);
                }
                */

                groundHolder.GetChild(0).SetSiblingIndex(2);



            }
        }
    }
}
