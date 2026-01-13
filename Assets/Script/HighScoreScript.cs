using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;



public class HighScoreScript : MonoBehaviour
{

    public TextMeshProUGUI highScoreText;

    void Start()
    {
        //Retrieve and display the high score at the start
        int highScore = PlayerPrefs.GetInt("HighScore");
        highScoreText.text = "High Score: " + highScore.ToString();
    }


}
