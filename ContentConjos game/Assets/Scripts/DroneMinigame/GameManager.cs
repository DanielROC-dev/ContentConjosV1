using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public Text introText;
    public Text gameOverText;
    public bool isGameActive = false;
    public static int highestScore;
    
    
    void Start()
    {
        score = 0;
    }

    public void UpdateScore(int scoreToAdd)
    {
        scoreText.gameObject.SetActive(true);
        score += scoreToAdd;
        scoreText.text = score.ToString();
        highestScore = score;
    }

    
    

    
    
}
