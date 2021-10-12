using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManagerContent : MonoBehaviour
{
    public GameObject goodOne;
    public GameObject enemy;

    public float distanceOffset = 0f;
    private float blueCircleGrabbed = 0f;
    public Text scoreText;
    public Text gameOverText;
    public Text startText;
    public Text text;
    public int score = 0;
    public int ammountHit = 0;
    public bool gameOver;
    public bool gameStarted;
    public GameObject RestartButton;
    string[] goodThings = {"inviting", "engaging", "authentic", "branding", "creative", "perzonalized", "memorable", "proffesional equipment", "clear message", "fun"};
    string[] badThings = {"boring", "weird", "off-rhythem", "no theme", "not consistent"};

  
    void Start() 
    {

       // Debug.Log(goodOneText.Text.text);
        gameOver = false;
        gameStarted = false;
       
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && gameStarted == false)
        {
         //   Debug.Log(ChildGameObject1[0].text + "bruh");
            gameStarted = true;
            startText.gameObject.SetActive(false);
            text.gameObject.SetActive(false);

            for(int count = 0; count < 10; count++)
            {
            Instantiate(goodOne);
            goodOne.GetComponentInChildren<TextMesh>().text = goodThings[count];
            }

            for(int count = 0; count < 5; count++)
            {
            Instantiate(enemy);
            enemy.GetComponentInChildren<TextMesh>().text = badThings[count];
            }
        }
        RaycastHit raycastHit; // dit zorgt ervoor dat muis input word gezien
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.green);
        if (Physics.Raycast(ray, out raycastHit, 100f))
        {
            if (raycastHit.transform != null && gameOver == false)
            {
                CurrentClickedGameObject(raycastHit.transform.gameObject);
            }
        }
        if(ammountHit == 10)
        {
            gameOver = true;
            Debug.Log("GameOver");
            gameOverText.gameObject.SetActive(true);
            scoreText.gameObject.SetActive(true);
            RestartButton.gameObject.SetActive(true);
        }
    }
 
    public void CurrentClickedGameObject(GameObject gameObject)
    {
    if(gameObject.tag=="target")
    {
        Destroy(gameObject);
        Debug.Log("destroyed target");
        blueCircleGrabbed++;
        ammountHit++;
        UpdateScore(10);
    }
        if(gameObject.tag=="enemy")
        {
            Destroy(gameObject);
            Debug.Log("destroyed target enemy");
            ammountHit++;
        }

        void UpdateScore(int scoreToAdd)
        {
            score += scoreToAdd;
            scoreText.text = (score + "%");
        }
    }    

  
}