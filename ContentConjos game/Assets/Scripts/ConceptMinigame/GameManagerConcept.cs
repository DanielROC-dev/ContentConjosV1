using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManagerConcept : MonoBehaviour
{
    public GameObject text;
    public GameObject buttonA;
    public GameObject buttonB;
    string[] Question1 = {"is dit een vraag?", "jazker", "denk het nie"};
    string[] Question2 = {"bruh?", "a", "b"};
    string[] Question3 = {"lolololol?", "aaaaaaaa", "bbbbbbbb"};
    int next;
    


    void Start()
    {
        next = 0;
        text.GetComponentInChildren<Text>().text = Question1[0];
        buttonA.GetComponentInChildren<Text>().text = Question1[1];
        buttonB.GetComponentInChildren<Text>().text = Question1[2];

        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void buttonAClicked()
    {
        next++;
        order();
    }

    public void buttonBClicked()
    {
        next++;
        order();
        
    }

    void order()
    {
        if(next == 1)
        {
            nextQuestion();
        }else if(next == 2)
        {
            nextNextQuestion();
        }
    }

    void nextQuestion()
    {            
        text.GetComponentInChildren<Text>().text = Question2[0];
        buttonA.GetComponentInChildren<Text>().text = Question2[1];
        buttonB.GetComponentInChildren<Text>().text = Question2[2];
        
    } 

    void nextNextQuestion()
    {
        text.GetComponentInChildren<Text>().text = Question3[0];
        buttonA.GetComponentInChildren<Text>().text = Question3[1];
        buttonB.GetComponentInChildren<Text>().text = Question3[2];
    }
    
}
