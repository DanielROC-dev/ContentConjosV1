using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void restart()
    {
        if(gameObject.tag == "restart")
        {

       
            if(GlobalData.droneGameAttempts > 0)
            {
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
            Debug.Log("next scene");
        }

    }
}
