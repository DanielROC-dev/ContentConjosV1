using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    float speed = 5;
    private float leftLimit = -20;
    
    private DroneScript droneScript;
    // Start is called before the first frame update
    void Start()
    {
        droneScript = GameObject.Find("Player").GetComponent<DroneScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(droneScript.gameOver == false){
        transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }
    }

    
   
}
