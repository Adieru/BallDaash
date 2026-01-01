using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinManagement : MonoBehaviour
{
    //Coin count
    private int coinCount = 0;

    //Text for the coin count display
    public TextMeshProUGUI coinText;

    //Audio source for coin collection sound
    public AudioSource coinAudio;

    void OnTriggerEnter(Collider other)
    {
        //Check if the object collided with is a coin
        if (other.gameObject.CompareTag("Coin"))
        {
            //Increment coin count
            coinCount++;

            //Deactivate the coin object
            other.gameObject.SetActive(false);

            //Display the updated coin count
            coinText.text = "Coin: " + coinCount.ToString();


        }
    }

}
