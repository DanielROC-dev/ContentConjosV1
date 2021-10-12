using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AddScoreDrone : MonoBehaviour
{
    public GameManager gameManager;
    void Start()
    {
        //find game manager script
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    public void OnTriggerEnter2D(Collider2D other) 
    {
        gameManager.UpdateScore(1);
    }
}
