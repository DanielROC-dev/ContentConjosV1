using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public GameManager gameManager;
   
    
    void start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    public void restart()
    {
        if(gameObject.tag == "restart")
        {
            if(GlobalData.droneGameAttempts > 0)
            {
                Debug.Log("end score: " + GameManager.highestScore);
                GlobalData.droneGameAttempts--;        
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }else if(GlobalData.droneGameAttempts == 0)
            {
                
                Debug.Log("no more attempts");
            }
        }
        if(gameObject.tag == "next")
        {
            // go next scene
            // GlobalData.totalScore = GameManager.highestScore;
            Debug.Log("next scene");
        }
    }
}
