using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DroneScript : MonoBehaviour
{
    
    public bool gameOver;
    public Animator anim;
    public bool gameStarted;
    private float gravity = 1.26f;
    private float gravityStasis = 0f;
    private float velocity = 300f;
    private GameManager gameManager;
    private Rigidbody2D rb;
    public GameObject pipes;
    public GameObject RestartButton;
    // Start is called before the first frame update
    void Start()
    {
        //collect components
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        rb = GetComponent<Rigidbody2D>();
        if(gameStarted == false){
            rb.gravityScale = gravityStasis;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver == false){
            if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0)){
                gameStarted = true;
                rb.AddForce(Vector2.up * velocity);         
            }  
            
        }

        if(gameStarted == true){
            rb.gravityScale = gravity;
            gameManager.introText.gameObject.SetActive(false); 
        }      
    }
    

    private void OnCollisionEnter2D(Collision2D other)
    {         
        if(other.gameObject.CompareTag("pipe"))
        {   
            gameManager.gameOverText.gameObject.SetActive(true);   
            
            Debug.Log("game over");  
            gameOver = true;
            anim.SetBool("GameEnd", true);    
            RestartButton.gameObject.SetActive(true);   
        
        }
    }

    
}