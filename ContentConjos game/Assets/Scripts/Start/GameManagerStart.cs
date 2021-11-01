using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameManagerStart : MonoBehaviour
{
   
    public GameObject firstScreen;
    public GameObject secondScreen;
    public GameObject[] buttons;
    public Text confirmationText;
    public Text introText;
    public Text title;
    public Text chooseConjoText;
    private int Lesley;
    private int Take;
    public AudioClip clickSound;
    public AudioSource AudioSource;
    private bool count;
    
    
    
    void Update()
    {
        // phone controlls support
        // iniate project tiny.
        if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            removeFirstScreen();
           // FindObjectOfType<AudioSource>().Play("ClickedSound");
           if(count == false)
           {
               AudioSource.PlayOneShot(clickSound, 2f);
               count = true;
               
           }
           
        }


    }



    void removeFirstScreen()
    {
        firstScreen.gameObject.SetActive(false); 
        chooseConjoText.gameObject.SetActive(true);
        introText.gameObject.SetActive(false); 
        title.gameObject.SetActive(false);
        for (int i = 0; i < 2; i++)
        {
            buttons[i].gameObject.SetActive(true);
        }
    }


    public void chooseLesley()
    {
        
       Lesley++;
        ChoseAnswer();
        
        
    }


    public void chooseTake()
    {
        
       Take++;
        ChoseAnswer();
        
    }


    public void ChoseAnswer()
    {

        confirmationText.gameObject.SetActive(true);
        if(Take == 1 && Lesley == 1)
        {
            confirmationText.GetComponentInChildren<Text>().text = "Final chance to change your mind?...";
        }
        
        if(Take == 2)
        {
            Debug.Log("chose take");
            GlobalData.chooseTake = true;
            //next scene
            LoadNextLevel();
        }

        if(Lesley == 2)
        {
            Debug.Log("chose lesley");
            GlobalData.chooseTake = false;
            //next scene
            LoadNextLevel();

        }


    }


    public void LoadNextLevel()
    {
        SceneManager.LoadScene("ConceptMinigame");
    }



}
