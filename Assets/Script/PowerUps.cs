using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class PowerUps : MonoBehaviour

{

    GameObject[] obstacles;

    private void OnTriggerEnter(Collider other)

    {

        if (other.gameObject.CompareTag("Invisible"))

        {

            StartCoroutine(ChangeInvisibleStatus());

        }

    }


    IEnumerator ChangeInvisibleStatus()

    {

        obstacles = GameObject.FindGameObjectsWithTag("Obstacles");
        BecomeInvis(true, 10);


        yield return new WaitForSeconds(5);

        BecomeInvis(false, 5);


    }


    void BecomeInvis(bool value, int playerSpeed)
    {

        for(int i = 0; i < obstacles.Length; i++)
        {
            obstacles[i].GetComponent<BoxCollider>().isTrigger = value;
        }

        this.GetComponent<PlayerMovement>().velocity = playerSpeed;
    }

}

