using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    private DroneScript droneScript;
    public GameObject pipe;
    private float pipeSpawnTimer = 1.6f;
    private float pipeHeightOffset = 3f;
    private float timer = 0;
    
    void Start(){
        droneScript = GameObject.Find("Player").GetComponent<DroneScript>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if(droneScript.gameStarted == true && droneScript.gameOver == false){
            if(timer > pipeSpawnTimer){
                GameObject newpipe = Instantiate(pipe);
                newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-pipeHeightOffset, pipeHeightOffset), 0);
                timer = 0;
            }
        }
        timer += Time.deltaTime;
    }
}
