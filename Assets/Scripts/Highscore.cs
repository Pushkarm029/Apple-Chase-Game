using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    public Text highScoreText;
    // Update is called once per frame
    void Update()
    {
        int highScore = PlayerPrefs.GetInt("HighScore");
        Debug.Log(highScore);
        highScoreText.text = "Highscore : "+ highScore;
    }
}
