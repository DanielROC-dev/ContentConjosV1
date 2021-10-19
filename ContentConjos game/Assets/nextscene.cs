using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextscene : StateMachineBehaviour
{
 
    void start()
    {
       SceneManager.LoadScene(1);
       Debug.Log("test 2");
    }
}